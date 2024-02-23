using tik4net;
using tik4net.Api;

namespace HumanIsLife
{
    class RouterosAPI
    {
        String? ipAddress;
        String? command;

        public void setConnection()
        {
            Console.Write("Masukan IpAddress : ");
            this.ipAddress = Console.ReadLine();

            Console.Write("Masukan Command : ");
            this.command = Console.ReadLine();

            var connection = tik4net.ConnectionFactory.OpenConnection(tik4net.TikConnectionType.Api,this.ipAddress,8278,"prom1se","asyncawait321");
            var data = connection.CreateCommand(this.command).ExecuteList();

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

    }
}
