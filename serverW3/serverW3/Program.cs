using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace serverW3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register channel
            TcpChannel channel = new TcpChannel(9000);
            ChannelServices.RegisterChannel(channel, false);
            OperationImpl lstA = new OperationImpl();
            OperationImpl lstB = new OperationImpl();
            OperationImpl lstP = new OperationImpl();
            OperationImpl lstS = new OperationImpl();
            OperationImpl lstW = new OperationImpl();
            lstB.addNewBrand(new Brands("BMW", "Немецкий производитель автомобилей, мотоциклов, двигателей, а также велосипедов"));
            lstB.addNewBrand(new Brands("Toyota", "Крупнейшая японская автомобилестроительная корпорация"));
            lstP.addNewPromotion(new Promotions("+1", "06.10.2020", 30, "Дополнительная гарантия на год"));
            lstP.addNewPromotion(new Promotions("Toyota30", "06.10.2020", 60, "Скидка в 30% на запчасти от Toyota"));
            lstS.addNewSupplier(new Suppliers("Аврора", "г. Санкт-Петербург, ул. Софийская, д. 2, лит. Б", 88123269217L, 7804371992L));
            lstS.addNewSupplier(new Suppliers("Орум", "г. Санкт-Петербург, ул. Лужская, д. 3", 78122488550L, 7810155397L));
            lstW.addNewWarranty(new Warranty("Стандартная BMW", 12));
            lstW.addNewWarranty(new Warranty("Стандартная Toyota", 18));

            // Register MyRemoteObject
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(OperationImpl),
                "TalkIsGood",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Press enter to stop this process.");
            Console.ReadLine();
        }
    }
}
