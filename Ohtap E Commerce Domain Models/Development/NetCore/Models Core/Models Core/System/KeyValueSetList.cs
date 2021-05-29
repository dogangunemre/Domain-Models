using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class KeyValueSetList<TKey, TValue> : Lista<KeyValueSet<TKey, TValue>>, IKeyValueSetList<KeyValueSet<TKey, TValue>>
    {
        public TValue this[TKey key]
        {
            get
            {
                TValue result = default(TValue);

                IKeyValueSet<TKey, TValue> kvc = this.FirstOrDefault(o => o.Key.Equals(key));
                if (kvc != null)
                {
                    result = kvc.Value;
                }

                return result;
            }
            set
            {
                IKeyValueSet<TKey, TValue> kvc = this.FirstOrDefault(o => (object)o.Key == (object)key);
                if (kvc != null)
                {
                    kvc.Value = value;
                }
                else
                {
                    this.Add(new KeyValueSet<TKey, TValue>(key, value));
                }
            }
        }
        public Lista<TKey> Keys
        {
            get
            {
                Lista<TKey> result = new Lista<TKey>();

                foreach (KeyValueSet<TKey, TValue> x in this)
                {
                    result.Add(x.Key);
                }

                return result;
            }
        }
        public Lista<TValue> Values
        {
            get
            {
                Lista<TValue> result = new Lista<TValue>();

                foreach (KeyValueSet<TKey, TValue> x in this)
                {
                    result.Add(x.Value);
                }

                return result;
            }
        }

        public KeyValueSetList() : base()
        {
        }


        public void Add(TKey key, TValue value)
        {
            base.Add(new KeyValueSet<TKey, TValue>(key, value));
        }
        public void Remove(TKey key)
        {
            KeyValueSet<TKey, TValue> kvc = this.FirstOrDefault(o => (object)o.Key == (object)key);
            if (kvc != null)
            {
                base.Remove(kvc);
            }
        }

        public bool HasKey(TKey key)
        {
            bool result = false;

            if (this[key] != null)
            {
                result = true;
            }

            return result;
        }
    }
}
