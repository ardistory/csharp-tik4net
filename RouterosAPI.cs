using tik4net;
using tik4net.Api;

namespace HumanIsLife
{
    class RouterosAPI
    {
        public void setConnection()
        {
            var connection = tik4net.ConnectionFactory.OpenConnection(tik4net.TikConnectionType.Api,"10.73.20.1",8278,"prom1se","asyncawait321");
            var data = connection.CreateCommand("/ip/address/print").ExecuteList();

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
