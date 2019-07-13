using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Stack
    {
        private ArrayList _stacked = new ArrayList();
        // A stack class with 3 methods, pushing an object into the stack, poping an object from the stack
        public void Push(object obj)
        {
            if (obj != null)
            {
                _stacked.Add(obj);
            }
            else
            {
                Console.WriteLine("The object was null and not pushed into the stack");
            }            
        }
        public object Pop()
        {
            if (_stacked.Count > 0)
            {
                var obj = _stacked[_stacked.Count - 1];                
                _stacked.RemoveAt(_stacked.Count - 1);
                return obj;
            }
            else
            {
                Console.WriteLine("The stack is empty");
                return null;
            }
                
        }
        public void Clear()
        {
            if (_stacked.Count > 0)
            {
                _stacked.Clear();
                Console.WriteLine("The stack has been cleared");
            }
            
            else
            {
                Console.WriteLine("The stack was already empty");
            }
        }
    }
}
