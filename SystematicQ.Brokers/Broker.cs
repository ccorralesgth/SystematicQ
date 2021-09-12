using SystematicQ.Brokers.Common.Interfaces;
using SystematicQ.Brokers.IB;
using SystematicQ.Brokers.TD;
using SystematicQ.Utils.Const;

namespace SystematicQ.Brokers
{
    /// <summary>
    /// concrete broker factory class [concrete creator]
    /// </summary>
    public class Broker : BrokerFactory
    {
        public override IBroker GetBroker(BrokerType brokerType)
        {
            IBroker activeBroker;
            switch (brokerType)
            {
                case BrokerType.TdAmeritrade:
                    activeBroker = new TDAmeritrade();
                    break;
                case BrokerType.InteractiveBroker:
                    activeBroker = new InteractiveBroker();
                    break;
                default:
                    activeBroker = null;
                    break;
            }
            return activeBroker;
        }
    }
}
