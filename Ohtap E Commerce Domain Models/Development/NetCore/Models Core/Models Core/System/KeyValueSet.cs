using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class KeyValueSet<TKey, TValue> : Objecta, IKeyValueSet<TKey, TValue>
    {
        private TKey _Key;
        public TKey Key { get => base.GetProperty(this._Key); set => base.SetProperty(ref this._Key, value); }

        private TValue _Value;
        public TValue Value { get => base.GetProperty(this._Value); set => base.SetProperty(ref this._Value, value); }


        public KeyValueSet()
        {

        }
        public KeyValueSet(TKey Key, TValue Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
