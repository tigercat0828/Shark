using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shark {
    class SingleLinkedList<T> : LinkedList<T> {
        public class Node<T> {
            public Node() {
                next = null;
            }
            public Node(T value) {
                data = value;
                next = null;
            }
            public T data;
            public Node<T> next;
        }
        public Node<T> Head;
        public override bool IsEmpty {
            get {
                if (Head == null)
                    return true;
                else
                    return false;
            }
            set {}
        }
        public SingleLinkedList() {
            Head = null;
            Length = 0;
        }
        public override void Delete(int index) {

        }

        public override void DeleteAll() {
            while(Head != null) {
                Node<T> target = Head;
                Head = Head.next;
                target = null;
            }
            Length = 0;
        }
        public override void DeleteBack() {
            if(Length == 0) {
                throw new IndexOutOfRangeException();
            }
            else if (Length == 1) {
                DeleteFront();
                Length--;
            }
            else {
                Node<T> previous = Head;
                Node<T> current = Head;
                while (current.next != null) {
                    previous = current;
                    current = current.next;
                }
                current = null;
                previous.next = null;
                Length--;
            }
            
        }
        public override void DeleteFront() {
            if (Length == 0) {
                throw new IndexOutOfRangeException();
            }
            else {

                Node<T> target = Head;
                Head = Head.next;
                target = null;
                Length--;
            }
        }
        public override T GetElement(int index) {
            if (index < Length) {

                Node<T> current = Head;
                int currIndex = 0;
                while (current.next != null && currIndex < index) {
                    current = current.next;
                    currIndex++;
                }
                return current.data;
            }
            else {
                Console.WriteLine("Out of index.");
                throw new IndexOutOfRangeException();
            }
        }
        public override void Insert(int index, T value) {
            if(index > Length - 1) {
                Console.WriteLine($"insert at index {index} failed.");
                throw new IndexOutOfRangeException();
            }
            else {
                int currIndex = 0;
                Node<T> current = Head;
                while(current.next != null && currIndex < index) {
                    current = current.next;
                    currIndex++;
                }
                Node<T> newNode = new Node<T>(value);
                newNode.next = current.next;
                current.next = newNode;
            }
        }
        public override void InsertBack(T value) {
            Node<T> newNode = new Node<T>(value);
            if (Head == null) {
                Head = newNode;
            }
            else {
                Node<T> current = Head;
                while (current.next != null) {
                    current = current.next;
                }
                current.next = newNode;
            }
            Length++;
        }
        public override void InsertFront(T value) {
            Node<T> newNode = new Node<T>(value);
            newNode.next = Head;
            Head = newNode;
            Length++;
        }
        public override int LocateElement(T value) {
            return 0;
        }
        public override void Traverse() {
            Console.Write("> ");
            Node<T> current = Head;
            while(current != null) {
                Console.Write(current.data);
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
