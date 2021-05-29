using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class Localization<T> : Objecta, ILocalization<T>
        where T : Objecta
    {
        private string _Region;
        public string Region { get => base.GetProperty(this._Region); set => base.SetProperty(ref this._Region, value); }

        private T _Content;
        public T Content { get => base.GetProperty(this._Content); set => base.SetProperty(ref this._Content, value); }


        public Localization()
        {
        }
        public Localization(string Region, T Content)
        {
            this.Region = Region;
            this.Content = Content;
        }
    }
}
