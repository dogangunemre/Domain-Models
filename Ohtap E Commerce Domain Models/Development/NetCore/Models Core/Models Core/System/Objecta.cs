using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public abstract class Objecta : IObjecta
    {
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
    }
}
