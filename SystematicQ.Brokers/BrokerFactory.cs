using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystematicQ.Brokers.Common.Interfaces;
using SystematicQ.Utils.Const;

namespace SystematicQ.Brokers
{
    /// <summary>
    /// abstract broker factory class [factory:creator]
    /// </summary>
    public abstract class BrokerFactory
    {
        public abstract IBroker GetBroker(BrokerType brokerType);
    }
}
