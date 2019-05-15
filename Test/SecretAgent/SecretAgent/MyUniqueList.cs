using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretAgent
{
    //- ItemAlreadyExistException
    //- ItemNotFoundException
    //- IndexOutOfRangeException
    class MyUniqueList<T>
    {
        List<T> list = new List<T>();

        public MyUniqueList()
        {

        }

        public bool Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }
            else
            {
                throw new ItemAlreadyExistException();
            }
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }
            else
            {
                throw new ItemNotFoundException();
            }
        }

        public T Peek(int index)
        {
            if (index > list.Count)
            {
                throw new MyIndexOutOfRangeException();
            }
            return list[index];
        }

        public T this[int index]
        {
            get
            {
                if (index > list.Count)
                {
                    throw new MyIndexOutOfRangeException();
                }
                return this.list[index];
            }
            set
            {
                if (list[index].Equals(value))
                    throw new ItemAlreadyExistException();
                if (list.Contains(value))
                    throw new ItemAlreadyExistException();
                list[index] = value;
            }
        }
    }
}
