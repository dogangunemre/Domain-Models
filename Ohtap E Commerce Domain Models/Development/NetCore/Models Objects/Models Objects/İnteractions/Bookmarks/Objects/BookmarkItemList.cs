﻿using Ohtap.ECommerce.Domain.Models.Core.System;
using Ohtap.ECommerce.Domain.Models.Objects.Bookmarks.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ohtap.ECommerce.Domain.Models.Objects.Bookmarks.Objects
{
    public class BookmarkItemList<T> : Lista<T>, IBookmarkItemList<T>
        where T : IBookmarkIdentity
    {
    }
}
