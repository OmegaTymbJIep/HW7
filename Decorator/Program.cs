using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteXmasTree and two Decorators
            ConcreteXmasTree c = new ConcreteXmasTree();
            Garland d1 = new Garland();
            Toys d2 = new Toys();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            c.ShowInfo();

            // Wait for user
            Console.Read();
        }
    }
    // "XmasTree"
    abstract class XmasTree
    {
        public abstract void ShowInfo();
    }

    // "ConcreteXmasTree"
    class ConcreteXmasTree : XmasTree
    {
        public override void ShowInfo()
        {
            Console.WriteLine("This is Christmas tree");
        }
    }
    // "Decorator"
    abstract class Decorator : XmasTree
    {
        protected XmasTree xmasTree;

        public void SetComponent(XmasTree xmasTree)
        {
            this.xmasTree = xmasTree;
        }
        public override void ShowInfo()
        {
            if (xmasTree != null)
            {
                xmasTree.ShowInfo();
            }
        }
    }

    // "Garland"
    class Garland : Decorator
    {
        

        public override void ShowInfo()
        {
            base.ShowInfo();
            GarlandInfo();
        }

        void GarlandInfo()
        {
            Console.WriteLine("It has garland and can light");
        }
    }

    // "Toys" 
    class Toys : Decorator
    {
        private string addedState;

        public override void ShowInfo()
        {
            base.ShowInfo();
            addedState = "It also has shiny toys";
            Console.WriteLine(addedState);
        }
        
    }
}
