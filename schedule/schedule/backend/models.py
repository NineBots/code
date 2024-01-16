from django.db import models
from django.core.validators import MaxValueValidator, MinValueValidator
from django.db.models import UniqueConstraint

#курс
class Course(models.Model):
    name_course = models.CharField(max_length=250)

    def __str__(self):
        return self.name_course

#группа пример (1 или 2)
class Group(models.Model):
    date_created = models.DateTimeField(auto_now_add=True)
    num_course = models.IntegerField(validators=[MinValueValidator(1), MaxValueValidator(7)])
    course = models.ForeignKey(Course, on_delete=models.CASCADE)
    num_group = models.IntegerField(validators=[MinValueValidator(1), MaxValueValidator(4)])

    def __str__(self):
        return f"{self.course}, {self.num_course} курс, {self.num_group} группа"

#неделя
class Week(models.Model):
    date_start = models.DateTimeField()
    type = models.CharField()

    def __str__(self):
        return str(self.date_start.date())

#неделя для группы
class WeekGroup(models.Model):
    week = models.ForeignKey(Week, on_delete=models.CASCADE)
    group = models.ForeignKey(Group, on_delete=models.CASCADE)

#день
class Day(models.Model):
    key = UniqueConstraint(fields =['week', 'week_day'], name='day in week')
    week = models.ForeignKey(WeekGroup, on_delete=models.CASCADE)
    week_day = models.IntegerField(validators=[MinValueValidator(1), MaxValueValidator(5)])

    def __str__(self):
        return self.week + ' ' + self.week_day

#урок
class Lesson(models.Model):
    name = models.CharField(max_length=150)
    order_lesson = models.IntegerField(blank=True)
    is_updated = models.BooleanField(default=False)
    day = models.ForeignKey(Day, on_delete=models.CASCADE)
    teacher = models.CharField(max_length=250)
    corpus = models.IntegerField()
    classroom = models.IntegerField()
    under_group = models.IntegerField(blank=True)

    def __str__(self):
        return f"{self.day} ({self.order_lesson}) {self.name} {self.teacher} {self.corpus} корпус {self.classroom} аудитория"