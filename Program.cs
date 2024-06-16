using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkFiveCrystalStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите сколько золота в вашем кошельке?: ");
            int golds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В вашем кошельке {golds} золота.");
            int crystallPrice = 5;
            Console.Write("Сколько кристаллов вы хотите купить?: ");
            int crystalls = Convert.ToInt32(Console.ReadLine());
            golds -= crystalls * crystallPrice;
            Console.WriteLine($"Вы купили {crystalls} кристалов, у вас осталось {golds} золота.");
        }
    }
}
