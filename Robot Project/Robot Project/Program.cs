using Robot_Project.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var krocoRobots = new List<RobotKroco>
            {
                new RobotKroco("Kroco1"),
                new RobotKroco("Kroco2"),
                new RobotKroco("Kroco3")
            };

            var bos = new BosRobot("BosRobot");

            IKemampuan[] kemampuanBos = { new SeranganListrik(), new Perbaikan(), new SeranganPlasma(), new PertahananSuper() };

            RobotSimulator simulator = new RobotSimulator(krocoRobots, bos, kemampuanBos);
            simulator.MulaiSimulasi();
        }
    }
}
