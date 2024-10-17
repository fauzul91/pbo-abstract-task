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
            // Membuat kemampuan
            IKemampuan seranganListrik = new SeranganListrik();
            IKemampuan perbaikan = new Perbaikan();
            IKemampuan seranganPlasma = new SeranganPlasma();
            IKemampuan pertahananSuper = new PertahananSuper();

            // Membuat robot biasa dan bos
            RobotKroco robot1 = new RobotKroco("Robot1", 100, 50, 50);
            RobotKroco robot2 = new RobotKroco("Robot2", 100, 50, 50);
            BosRobot bos = new BosRobot("Bos Robot", 200, 100, 75);

            while (true)
            {
                Console.WriteLine("\n=== Pertarungan Robot ===");
                Console.WriteLine("1. Robot1 menyerang Bos");
                Console.WriteLine("2. Robot2 menyerang Bos");
                Console.WriteLine("3. Gunakan kemampuan khusus pada Bos");
                Console.WriteLine("4. Cetak informasi robot");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih opsi: ");

                string pilihan = Console.ReadLine();
                switch (pilihan)
                {
                    case "1":
                        robot1.Serang(bos);
                        break;

                    case "2":
                        robot2.Serang(bos);
                        break;

                    case "3":
                        GunakanKemampuan(robot1, robot2, bos, seranganListrik, seranganPlasma, perbaikan, pertahananSuper);
                        break;

                    case "4":
                        Console.WriteLine("\nInformasi Robot:");
                        robot1.CetakInformasi();
                        robot2.CetakInformasi();
                        bos.CetakInformasi();
                        break;

                    case "5":
                        Console.WriteLine("Keluar dari program.");
                        return;

                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }
            }
        }

        static void GunakanKemampuan(RobotKroco robot1, RobotKroco robot2, BosRobot bos, IKemampuan seranganListrik, IKemampuan seranganPlasma, IKemampuan perbaikan, IKemampuan pertahananSuper)
        {
            Console.WriteLine("\nPilih kemampuan yang akan digunakan:");
            Console.WriteLine("1. Serangan Listrik");
            Console.WriteLine("2. Serangan Plasma");
            Console.WriteLine("3. Perbaikan");
            Console.WriteLine("4. Pertahanan Super");
            Console.Write("Masukkan pilihan kemampuan: ");

            string pilihanKemampuan = Console.ReadLine();

            Console.WriteLine("\nPilih robot yang akan menggunakan kemampuan:");
            Console.WriteLine("1. Robot1");
            Console.WriteLine("2. Robot2");
            Console.Write("Masukkan pilihan robot: ");

            string pilihanRobot = Console.ReadLine();
            Robot pengguna;

            if (pilihanRobot == "1")
            {
                pengguna = robot1;
            }
            else
            {
                pengguna = robot2;
            }

            switch (pilihanKemampuan)
            {
                case "1":
                    pengguna.GunakanKemampuan(seranganListrik, bos);
                    seranganListrik.KurangiCooldown();
                    break;

                case "2":
                    pengguna.GunakanKemampuan(seranganPlasma, bos);
                    seranganPlasma.KurangiCooldown();
                    break;

                case "3":
                    pengguna.GunakanKemampuan(perbaikan, pengguna);
                    perbaikan.KurangiCooldown();
                    break;

                case "4":
                    pengguna.GunakanKemampuan(pertahananSuper, pengguna);
                    pertahananSuper.KurangiCooldown();
                    break;

                default:
                    Console.WriteLine("Pilihan kemampuan tidak valid.");
                    break;
            }
        }
    }
}
