using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo_01
{
    class Stack<T>
    {

        private StackElement<T> current;

        //successor muss direkt im StackElement gespeichert werden! sonst keine LinkedList
        //private StackElement<T> successor;

        //push-Methode: neues Objekt hinzufügen 
        public void Push(T item)
        {
            if (current == null)
            {
                current = new StackElement<T>() { Value = item, PreSuccessor = null };
            }
            else
            {
                StackElement<T> temp = new StackElement<T>() { Value = item, PreSuccessor = current };
                current = temp;
            }
        }

        //pop-Methode: ein Objekt entfernen + gelöschtes soll wiedergegeben werden
        public T Pop()
        {
            if (current != null)
            {
                T temp = current.Value;
                current = current.PreSuccessor;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        //peek-Methode: gibt das zuletzt hinzugefügte Objekt aus
        public T Peek()
        {
            if (current != null)
            {
                return current.Value;
            }
            else
            {
                return default(T);
            }
        }

    }
}
