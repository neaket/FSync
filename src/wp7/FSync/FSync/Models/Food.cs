using System;
using System.Collections.Generic;

namespace FSync.Models
{
    public class Food
    {
        public string AccessLevel { get; set; }
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Calories { get; set; }
        public int DefaultServingSize { get; set; }
        public Unit DefaultUnit { get; set; }
        public Locale Locale { get; set; }
        public string Name { get; set; }
        public IList<Serving> Servings { get; private set; }
        public IList<Unit> Units { get; private set; }
        // TODO find out the variable type
        public IDictionary<string, float> NutritionalValues { get; set; }

        public Food()
        {
            Servings = new List<Serving>();
            Units = new List<Unit>();
        }
    }

    public class FoodLog : Food
    {
        public float Amount { get; set; }
        public int MealTypeId { get; set; }
        public DateTime Date { get; set; }
        public bool AddToFavorites { get; set; }
    }

    public enum MealType
    {
        Breakfast = 1,
        MorningSnack = 2,
        Lunch = 3,
        AfternoonSnack = 4,
        Dinner = 5,
        Anytime = 7
    }

    public class Serving
    {
        public float Multiplier { get; set; }
        public float ServingSize { get; set; }
        public int Id { get; set; }
        public Unit Unit { get; set; }
    }
}
