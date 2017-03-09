using System.Collections;
using System.Collections.Generic;

namespace RoleAndParty.Classes
{
    public class Archetypes<T> : Archetype, IList<T>
    {
        private readonly List<T> list = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item) //testitud
        {
            list.Add(item);
        }

        public void Clear() //testitud; kuidas testida ilma teisi meetodeid kasutamata..
        {
            list.Clear();
        }

        public bool Contains(T item) // testimata
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item) //testitud
        {
            return list.Remove(item);
        }

        public int Count => list.Count;
        public bool IsReadOnly { get; } = false;

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
    }
}
