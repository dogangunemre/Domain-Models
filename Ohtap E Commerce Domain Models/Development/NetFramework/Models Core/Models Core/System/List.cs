using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class Lista<T> : ILista<T>
    {
        private List<T> innerList = new List<T>();


        public Lista()
        {

        }

        public T this[int index] { get { return this.innerList[index]; } set { this.innerList[index] = value; } }

        public int Count { set { } get { return this.innerList.Count; } }

        public bool IsReadOnly { set { } get { return false; } }

        public void Add(T item)
        {
            this.innerList.Add(item);
        }

        public void Clear()
        {
            this.innerList.Clear();
        }

        public bool Contains(T item)
        {
            return this.innerList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.innerList.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.innerList.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return this.innerList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this.innerList.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return this.innerList.Remove(item);
        }

        public void RemoveAt(int index)
        {
            this.innerList.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.innerList.GetEnumerator();
        }
    }
}
