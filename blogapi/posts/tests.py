from django.test import TestCase
from django.contrib.auth.models import User
from .models import Post
# Create your tests here.


class CreateTests(TestCase):
    @classmethod
    def setUpTestData(cls):
        #create user
        test_user1 = User.objects.create_user(username='test_user1', password='test_user1')
        test_user1.save()

        #create post
        test_post1 = Post.objects.create(author=test_user1, title='test_post1', body='test_post1')
        test_post1.save()

    def testBlog(self):
        post = Post.objects.get(id=1)
        author = f'{post.author}'
        title = f'{post.title}'
        body = f'{post.body}'
        self.assertEqual(author, 'test_user1')
        self.assertEqual(title, 'test_post1')
        self.assertEqual(body, 'test_post1')