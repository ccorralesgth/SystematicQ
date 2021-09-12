using System;
using System.Threading.Tasks;
using SystematicQ.Brokers.Common.Interfaces;
using SystematicQ.Brokers.IB;
using SystematicQ.Brokers.TD;
using SystematicQ.Utils.Const;

namespace SystematicQ.Brokers
{
    class Program
    {
        static void Main(string[] args)
        {
            //example use of broker factory

            IBroker td = new Broker().GetBroker(BrokerType.TdAmeritrade);
            IBroker ib = new Broker().GetBroker(BrokerType.InteractiveBroker);

            Console.ReadLine();          
        }

    }

    
}
