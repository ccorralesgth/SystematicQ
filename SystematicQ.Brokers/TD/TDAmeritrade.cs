using System;
using System.Threading.Tasks;
using SystematicQ.Brokers.Common.Interfaces;

namespace SystematicQ.Brokers.TD
{
    /// <summary>
    /// TDAmeritrade class [factory: concrete product]
    /// </summary>
    internal class TDAmeritrade : IBroker
    {
        /// <summary>
        /// constructor
        /// </summary>
        public TDAmeritrade()
        {
            Console.WriteLine("td broker created");
            AuthenticateAsync();
        }
        public async Task AuthenticateAsync()
        {
            await Task.Run(() => { Console.WriteLine("td broker authenticated"); });

            //throw new NotImplementedException();
        }
    }
}
