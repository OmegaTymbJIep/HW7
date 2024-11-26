using System;
namespace AdapterExample
{
    class UsbTypeA
    {
        public string MatchTypeASocket()
        {
            return "Type A socket";
        }
    }
    
    interface IUsbTypeC
    {
        string MatchTypeCSocket();
    }

    class UsbTypeC : IUsbTypeC
    {
        public string MatchTypeCSocket()
        {
            return "Type C socket";
        }
    }

    class Adapter : IUsbTypeC
    {
        private readonly UsbTypeA _adaptee;
        public Adapter(UsbTypeA adaptee)
        {
            _adaptee = adaptee;
        }

        public string MatchTypeCSocket()
        {
            return _adaptee.MatchTypeASocket();
        }
    }

     class FleshCard
    {
        public static void ExchangeFiles(IUsbTypeC usbPort)
        {
            Console.WriteLine(usbPort.MatchTypeCSocket());
        }
    }

    public class AdapterDemo
    {
        static void Main()
        {
            var UsbTypeC = new UsbTypeC();
            FleshCard.ExchangeFiles(UsbTypeC);
            var oldElectricitySystem = new UsbTypeA();
            var adapter = new Adapter(oldElectricitySystem);
            FleshCard.ExchangeFiles(adapter);            
            Console.ReadKey();
        }
    }
}
