from django.urls import path

from .views import *

urlpatterns = [
    path('schedule/', show_schedule),
    path('test/', show_test ),
]