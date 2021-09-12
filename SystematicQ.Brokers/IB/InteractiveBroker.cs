using System;
using System.Threading.Tasks;
using SystematicQ.Brokers.Common.Interfaces;

namespace SystematicQ.Brokers.IB
{
    /// <summary>
    /// Interactive Broker class [concrete product]
    /// </summary>
    public class InteractiveBroker : IBroker
    {
        /// <summary>
        /// constructor
        /// </summary>
        public InteractiveBroker()
        {
            Console.WriteLine("ib broker created");
            AuthenticateAsync();
        }

        public async Task AuthenticateAsync()
        {
            await Task.Run(() => { Console.WriteLine("ib broker authenticated"); });
            //throw new NotImplementedException();
        }
    }
}
