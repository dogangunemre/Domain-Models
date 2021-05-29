using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class Lista<T> : List<T>, ILista<T>
    {
        private List<T> innerList = new List<T>();

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        protected void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, e);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void CallPropertyChanged<T>(Expression<Func<T>> expression)
        {
            MemberExpression body = (MemberExpression)expression.Body;
            OnPropertyChanged(body.Member.Name);
        }
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
        protected T GetProperty<T>(T backingStore, [CallerMemberName] string propertyName = "")
        {
            T sonuc = default(T);
            sonuc = backingStore;
            return sonuc;
        }

        public Lista()
        {

        }
        public Lista(IEnumerable<T> collection)
        {
            this.AddRange(collection);
        }

        public virtual void AddIfNotExist(T item)
        {
            if (!this.innerList.Contains(item))
            {
                this.innerList.Add(item);
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            }
        }
        public virtual void AddRange(params T[] items)
        {
            foreach (T item in items)
            {
                this.innerList.Add(item);
                this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            }
        }
        public virtual void AddRangeIfNotExist(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                if (!this.innerList.Contains(item))
                {
                    this.innerList.Add(item);
                    this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
                }
            }
        }
        public virtual void AddRangeIfNotExist(params T[] items)
        {
            foreach (T item in items)
            {
                if (!this.innerList.Contains(item))
                {
                    this.innerList.Add(item);
                    this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
                }
            }
        }
    }
}
