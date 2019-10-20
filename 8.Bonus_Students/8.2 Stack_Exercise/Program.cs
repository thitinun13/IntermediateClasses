using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
                _stack.Push(i);

            for (int i = ini; i <= max; i++)
                Console.WriteLine(_stack.Pop());

            Console.ReadLine();
        }
    }
    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You cann't add a null object");

            _list.Add(obj);
            int elements = _list.Count;
            if (elements > 1)
            {
                for (int i = elements - 1; i > 0; i++)
                {
                    _list[i] = _list[i - 1];
                }
                _list[0] = obj;
            }

        }
        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("No element in the stack yet");
            object ToReturn = _list[0];

            int elements = _list.Count;
            for (int i = 0; i < elements - 1; i++)
            {
                _list[i] = (int)_list[i + 1];
            }
            _list.Remove(elements - 1);

            return (ToReturn);
        }
    }
}
