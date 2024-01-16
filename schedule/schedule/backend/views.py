from django.shortcuts import render
from .models import *

def show_schedule(request):
    Courses = Course.objects.all()
    Groups = Group.objects.all()
    Days = Day.objects.all()
    Lessons = Lesson.objects.all()

    return render(request, 'backend/schedule.html', {'courses': Courses, 'groups': Groups, 'days': Days, 'lessons': Lessons})

def show_test(request):

    return render(request, 'backend/front/index.html')
