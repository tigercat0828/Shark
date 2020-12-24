using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shark {
    class MainProgram {
        static void Main(string[] args) {
            SingleLinkedList<int> A = new SingleLinkedList<int>();
            A.InsertBack(1);
            A.InsertBack(2);
            A.InsertBack(3);
            A.InsertBack(4);
            A.Traverse();
            Console.WriteLine(A.Length);
            Console.ReadLine();
        }
        
        
    }
}
