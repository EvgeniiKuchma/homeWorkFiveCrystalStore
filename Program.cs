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
            int goldInWallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В вашем кошельке {goldInWallet} золота.");
            int costOneCrystal = 5;
            Console.Write("Сколько кристаллов вы хотите купить?: ");
            int numberOfCrystal = Convert.ToInt32(Console.ReadLine());
            goldInWallet -= numberOfCrystal * costOneCrystal;
            Console.WriteLine($"Вы купили {numberOfCrystal} кристалов, у вас осталось {goldInWallet} золота.");
        }
    }
}
