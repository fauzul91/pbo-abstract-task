using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class RobotSimulator
    {
        private List<RobotKroco> krocoRobots;
        private BosRobot bos;
        private IKemampuan[] kemampuanBos;
        private Random rand;

        public RobotSimulator(List<RobotKroco> krocoRobots, BosRobot bos, IKemampuan[] kemampuanBos)
        {
            this.krocoRobots = krocoRobots;
            this.bos = bos;
            this.kemampuanBos = kemampuanBos;
            this.rand = new Random();
        }

        public void MulaiSimulasi()
        {
            while (krocoRobots.Exists(r => r.Energi > 0) && bos.Energi > 0)
            {
                Console.WriteLine("===== Ronde Baru =====");

                foreach (var kroco in krocoRobots)
                {
                    if (kroco.Energi > 0)
                    {
                        Console.WriteLine($"{kroco.Nama} Giliran:");
                        int pilihanAksiKroco = rand.Next(2); // 0: serang, 1: kemampuan
                        if (pilihanAksiKroco == 0)
                        {
                            kroco.Serang(bos);
                        }
                        else
                        {
                            int kemampuanIndex = rand.Next(kemampuanBos.Length);
                            kroco.GunakanKemampuan(kemampuanBos[kemampuanIndex], bos);
                        }
                        Console.WriteLine();
                    }
                }

                if (bos.Energi <= 0)
                {
                    bos.Mati();
                    Console.WriteLine("Simulasi selesai! Bos Robot kalah!");
                    break;
                }

                Console.WriteLine($"{bos.Nama} Giliran:");
                int bosPilihanAksi = rand.Next(2); // 0: serang, 1: kemampuan
                if (bosPilihanAksi == 0)
                {
                    foreach (var kroco in krocoRobots)
                    {
                        if (kroco.Energi > 0)
                        {
                            bos.Serang(kroco);
                            break; 
                        }
                    }
                }
                else
                {
                    int kemampuanIndex = rand.Next(kemampuanBos.Length);
                    bos.GunakanKemampuan(kemampuanBos[kemampuanIndex], krocoRobots[rand.Next(krocoRobots.Count)]);
                }
                Console.WriteLine();

                if (krocoRobots.All(r => r.Energi <= 0))
                {
                    Console.WriteLine("Semua Robot Kroco telah mati! Bos menang!");
                    break;
                }

                foreach (var kroco in krocoRobots)
                {
                    if (kroco.Energi <= 0)
                    {
                        Console.WriteLine($"{kroco.Nama} telah mati!");
                    }
                }

                if (bos.Energi <= 0)
                {
                    bos.Mati();
                    Console.WriteLine("Simulasi selesai! Bos Robot kalah!");
                }
            }
        }
    }
}