using System.ServiceProcess;

namespace DSM.Agents.TrackerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceBase.Run(new TrackerService());
        }
    }
}
