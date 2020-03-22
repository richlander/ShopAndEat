﻿using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class Ingredient : IIngredient
    {
        public Ingredient(IArticle article, in int quantity, IUnit unit)
        {
            Article = article;
            Quantity = quantity;
            Unit = unit;
        }

        public IArticle Article { get; }

        public int Quantity { get; }

        public IUnit Unit { get; }
    }
}