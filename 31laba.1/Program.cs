using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31laba._1
{
    /*
     Шеф повар. Визначити ієрархію овочів. Зробити салат. Підрахувати калорійність.
     Провести сортування овочів для салату на основі одного з параметрів. Знайти 
     овочі в салаті, відповідні заданому діапазону калорійності.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Vegetables avocado = new Vegetables("Avocados", 160, 100, 2, 14.66, 1.83);
            Vegetables cucumber = new Vegetables("Cucumbers", 15, 100, 0.7, 0.1, 3.0);
            Vegetables greens = new Vegetables("Greens", 12, 100, 1.2, 0.3, 1.3);
            Vegetables spinach = new Vegetables("Spinach", 17, 100, 2.7, 0.4, 0.8);
            Vegetables tomato = new Vegetables("Tomatos", 19, 100, 0.8, 0.3, 3.5);
            Chef salad = new Chef(avocado, cucumber, greens, spinach, tomato);
           /* salad.Hierarchy();
            salad.MixSalat();
            salad.SumKkal();
            salad.SortProteins();
            salad.ShowList();
            salad.FindByCalories();*/
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
