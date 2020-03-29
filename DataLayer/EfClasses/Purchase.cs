using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DataLayer.EfClasses
{
    public class Purchase
    {
        private readonly List<PurchaseItem> _purchaseItems;

        public Purchase(in DateTime from, in DateTime to, IEnumerable<PurchaseItem> purchaseItems)
        {
            _purchaseItems = purchaseItems.ToList();
            From = from;
            To = to;
        }

        public DateTime From { get; }

        public DateTime To { get; }

        public IReadOnlyCollection<PurchaseItem> PurchaseItems => new ReadOnlyCollection<PurchaseItem>(_purchaseItems);
    }
}