using System;
using System.Collections.Generic;

namespace DataLayer.Core
{
    public interface IPurchase
    {
        DateTime From { get; }

        DateTime To { get; }

        IReadOnlyCollection<(IIngredient, int)> Components { get; }
    }
}