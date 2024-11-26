using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MakeCoffee();
            facade.MakeTea();
            // Wait for user 
            Console.Read();
        }
    }


    // Subsystem ClassA
    class WaterBoiler
    {
        public void BoilWater()
        {
            Console.WriteLine("BoilWater Method");
        }
    }

    // Subsystem ClassB
    class CoffeeBrewer
    {
        public void BrewCoffee()
        {
            Console.WriteLine("BrewCoffe Method");
        }
    }


    // Subsystem ClassC
    class BeansGrinder
    {
        public void GrindBeans()
        {
            Console.WriteLine("GrindBeans Method");
        }
    }
    // Subsystem ClassD
    class TeaPourer
    {
        public void PourTea()
        {
            Console.WriteLine("PourTea Method");
        }
    }
    // Facade
    class Facade
    {
        WaterBoiler one;
        CoffeeBrewer two;
        BeansGrinder three;
        TeaPourer four;

        public Facade()
        {
            one = new WaterBoiler();
            two = new CoffeeBrewer();
            three = new BeansGrinder();
            four = new TeaPourer();
        }

        public void MakeCoffee()
        {
            Console.WriteLine("\nMakeCoffee() ---- ");
            one.BoilWater();
            two.BrewCoffee();
            three.GrindBeans();
        }

        public void MakeTea()
        {
            Console.WriteLine("\nMakeTea ---- ");
            one.BoilWater();
            four.PourTea();
        }
    }
}
