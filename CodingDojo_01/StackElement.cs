using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_01
{
    class StackElement<T>
    {
        public T Value { get; set; } //speichert den Wert des neuen Objektess

        public StackElement<T> PreSuccessor { get; set; }
    }
}
