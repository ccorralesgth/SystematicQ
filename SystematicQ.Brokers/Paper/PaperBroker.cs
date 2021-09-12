using System;
using System.Threading.Tasks;
using SystematicQ.Brokers.Common.Interfaces;

namespace SystematicQ.Brokers.Paper
{
    /// <summary>
    /// Paper Broker class [factory: concrete product]
    /// </summary>
    public class PaperBroker : IBroker
    {
        /// <summary>
        /// constructor
        /// </summary>
        public PaperBroker()
        {
            Console.WriteLine("paper broker created");
            AuthenticateAsync();
        }
        public async Task AuthenticateAsync()
        {
            Console.WriteLine("paper broker authenticated");

            //throw new NotImplementedException();
        }
    }
}
