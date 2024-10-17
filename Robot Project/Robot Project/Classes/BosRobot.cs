using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class BosRobot : Robot
    {
        public BosRobot(string nama, int energi, int armor, int serangan)
            : base(nama, energi, armor, serangan) { }

        public override void GunakanKemampuan(IKemampuan kemampuan, Robot target)
        {
            kemampuan.Gunakan(this, target);
        }

        public void Diserang(Robot penyerang)
        {
            int seranganYangDiterima = penyerang.Serangan;
            // Mengurangi armor terlebih dahulu jika masih ada
            if (Armor > 0)
            {
                if (seranganYangDiterima >= Armor)
                {
                    seranganYangDiterima -= Armor;
                    Armor = 0;
                    Console.WriteLine($"{penyerang.Nama} menghancurkan armor {Nama}.");
                }
                else
                {
                    Armor -= seranganYangDiterima;
                    seranganYangDiterima = 0;
                    Console.WriteLine($"{penyerang.Nama} mengurangi armor {Nama} sebanyak {penyerang.Serangan}.");
                }
            }

            // Mengurangi energi jika ada sisa serangan
            if (seranganYangDiterima > 0)
            {
                Energi -= seranganYangDiterima;
                if (Energi < 0)
                {
                    Energi = 0; // Mencegah nilai negatif
                }
                Console.WriteLine($"{penyerang.Nama} menyerang {Nama}, mengurangi energi sebesar {seranganYangDiterima}.");
            }

            // Mengecek apakah energi habis
            if (Energi <= 0)
            {
                Mati();
            }
        }

        // Metode yang akan dipanggil jika energi bos habissssssss
        public void Mati()
        {
            Console.WriteLine($"Bos {Nama} telah mati.");
        }
    }
}
