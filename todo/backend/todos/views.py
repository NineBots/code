from .serializers import TodoSerializer
from rest_framework import generics
from .models import Todo

class ListToDo(generics.ListAPIView):
    queryset = Todo.objects.all()
    serializer_class = TodoSerializer

class DetailToDo(generics.RetrieveAPIView):
    queryset = Todo.objects.all()
    serializer_class = TodoSerializer


# Create your views here.
