using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shark {
    class SingleLinkedList<T> : LinkedList<T> {
        class Node<T> {
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
        private Node<T> Head;
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
            throw new NotImplementedException();
        }
        public override void DeleteAll() {
            throw new NotImplementedException();
        }
        public override void DeleteBack() {
            throw new NotImplementedException();
        }
        public override void DeleteFront() {
            throw new NotImplementedException();
        }
        public override T GetElement(int index) {
            return Head.data;
        }
        public override void Insert(int index, T value) {
            Node<T> current = new Node<T>();
            int currIndex = -1;
            while(currIndex < index && current.next != null) {
                current = current.next;
                currIndex++;
            }
            Node<T> newNode = new Node<T>();
            newNode.next = current.next;
            current.next = newNode;
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
            Node<T> current = Head;
            while(current != null) {
                Console.Write(current.data);
                current = current.next;
            }
            Console.WriteLine();
        }

       
    }
}
