using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Purchase : IPurchase
    {
        private readonly IEnumerable<IPurchaseItem> _purchaseItems;

        public Purchase(in DateTime from, in DateTime to, IEnumerable<IPurchaseItem> purchaseItems)
        {
            _purchaseItems = purchaseItems;
            From = from;
            To = to;
        }

        public DateTime From { get; }

        public DateTime To { get; }

        public IReadOnlyCollection<IPurchaseItem> PurchaseItems => new ReadOnlyCollection<IPurchaseItem>(_purchaseItems.ToList());
    }
}