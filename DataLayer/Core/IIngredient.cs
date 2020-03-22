﻿namespace DataLayer.Core
{
    public interface IIngredient
    {
        IArticle Article { get; }

        int Quantity { get; }

        IUnit Unit { get; }
    }
}