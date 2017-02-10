using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class SieveList : IEnumerable<int>
    {
        private Node<int> _head;
        private Node<int> _tail;
        private int _bound;

        public SieveList() { }

        public SieveList(int bound)
        {
            _bound = bound;
            BuildList(bound);
        }

        public void BuildList(int bound)
        {
            _bound = bound;
            _head = new Node<int>(2);
            _tail = _head;
            for (int i = 3; i <= bound; i++)
            {
                Node<int> newNode = new Node<int>(i);
                _tail.Next = newNode;
                _tail = newNode;
            }
        }

        public void FindPrimes()
        {
            Node<int> deletePointer = _head;
            while (deletePointer.HasNext())
            {
                if (deletePointer.Data >= Math.Sqrt(_bound))
                {
                    break;
                }
                DeleteMultiples(deletePointer);
                deletePointer = deletePointer.Next;
            }
        }

        private void DeleteMultiples(Node<int> node)
        {
            int factor = node.Data;
            Node<int> stepPointer = node;
            while (stepPointer.HasNext())
            {
                if (stepPointer.Next.Data % factor == 0)
                {
                    stepPointer.Next = stepPointer.Next.Next;
                }
                if (!stepPointer.HasNext())
                {
                    break;
                }
                stepPointer = stepPointer.Next;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SieveEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }

    class SieveEnumerator : IEnumerator<int>
    {
        Node<int> _current;

        public SieveEnumerator(Node<int> head)
        {
            Node<int> dummy = new Node<int>(0);
            dummy.Next = head;
            _current = dummy;
        }

        public int Current
        {
            get
            {
                return _current.Data;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (!_current.HasNext())
            {
                return false;
            }
            _current = _current.Next;
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

    class Node<T>
    {
        private T _data;
        private Node<T> _next;

        public Node(T d)
        {
            _data = d;
            _next = null;
        }

        public T Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }

        public bool HasNext()
        {
            return _next != null;
        }
    }
}
