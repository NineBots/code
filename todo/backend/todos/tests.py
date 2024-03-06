from django.test import TestCase
from .models import Todo

class TodoModelTest(TestCase):
    @classmethod
    def setUpTestData(cls):
        Todo.objects.create(title='test', body='test')

    def test_title_content(self):
        todo = Todo.objects.get(id=1)
        expected_title = f'{todo.title}'
        self.assertEqual(expected_title, 'test')

    def test_description_content(self):
        todo = Todo.objects.get(id=1)
        expected_description = f'{todo.body}'
        self.assertEqual(expected_description, 'test')

# Create your tests here.
