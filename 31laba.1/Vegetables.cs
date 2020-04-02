using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31laba._1
{
    class Vegetables
    {
        //Vegetables? What are they?
        public string name;
        public int calories;
        public int grams;
        public double proteins;
        public double fats;
        public double carbohydrates;
        public Vegetables(string Name, int Calories, int Grams, double Proteins, double Fats, double Carbohydrates)
        {
            this.name = Name;
            this.calories = Calories;
            this.grams = Grams;
            this.proteins = Proteins;
            this.fats = Fats;
            this.carbohydrates = Carbohydrates;
        }
    }
   
}
