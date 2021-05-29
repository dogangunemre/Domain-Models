using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Core.System
{
    public class LocalizationList<T> : Lista<Localization<T>>, ILocalizationList<Localization<T>>
        where T : Objecta
    {
        public T this[string Language]
        {
            get
            {
                T result = null;

                Localization<T> item = this.FirstOrDefault(o => o.Region == Language);
                if (item != null)
                {
                    result = item.Content;
                }

                return result;
            }
            set
            {
                Localization<T> item = this.FirstOrDefault(o => o.Region == Language);
                if (item == null)
                {
                    this.Add(new Localization<T>(Language, value));
                }
                else
                {
                    item.Content = value;
                }
            }
        }
        public LocalizationList()
        {
        }
    }
}
