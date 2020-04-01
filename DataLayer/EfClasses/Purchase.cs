using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class Purchase
    {
        private readonly List<PurchaseItem> _purchaseItems;

        public Purchase(DateTime from, DateTime to, IEnumerable<PurchaseItem> purchaseItems)
        {
            _purchaseItems = purchaseItems.ToList();
            From = from;
            To = to;
        }

        [UsedImplicitly]
        private Purchase()
        {
        }

        public DateTime From { get; }

        public DateTime To { get; }

        public IReadOnlyCollection<PurchaseItem> PurchaseItems => new ReadOnlyCollection<PurchaseItem>(_purchaseItems);

        public int PurchaseId { get; [UsedImplicitly] private set; }
    }
}