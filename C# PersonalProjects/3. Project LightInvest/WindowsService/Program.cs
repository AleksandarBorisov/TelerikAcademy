using System.ServiceProcess;

namespace LightInvest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new LightInvestService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
