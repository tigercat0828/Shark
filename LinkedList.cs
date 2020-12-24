using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shark {
    abstract class LinkedList<T> {
        public int Length;
        abstract public bool IsEmpty { get; set; }
        abstract public void Insert(int index, T value);
        abstract public void InsertFront(T value);
        abstract public void InsertBack(T value);
        abstract public void Delete(int index);
        abstract public void DeleteFront();
        abstract public void DeleteBack();
        abstract public void DeleteAll();
        abstract public int LocateElement(T value);
        abstract public T GetElement(int index);
        abstract public void Traverse();
    }
}
