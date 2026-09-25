using System;
using System.Collections.Generic;
using System.Text;

namespace C_Notes.Chapter_5_Generics
{
    //LinkedList//
    using System;

    class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    class MyLinkedList<T>
    {
        private Node<T> head;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void Display()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
