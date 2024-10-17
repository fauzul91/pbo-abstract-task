using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class SeranganPlasma : IKemampuan
    {
        int cooldown;

        public void Gunakan(Robot pengguna, Robot target)
        {
            int SeranganPlasma = 20;
            if (cooldown > 0)
            {
                Console.WriteLine("Kemampuan Serangan Plasma Sedang Cooldown!");
                return;
            }
            else if (SeranganPlasma >= target.Energi)
            {
                target.Energi = 0; // Energi target menjadi 0 
                Console.WriteLine($"Robot {pengguna.Nama} Menembakkan Plasma Cannon! pada {target.Nama}");
                Console.WriteLine($"Robot {target.Nama} telah terbunuh karena kehabisan energi disebabkan oleh Plasma Cannon.");
            }
            else
            {
                // Jika serangan tidak membunuh target, kurangi energi target
                target.Energi -= SeranganPlasma;
                Console.WriteLine($"Robot {pengguna.Nama} Menembakkan Plasma Cannon! pada {target.Nama}, mengurangi energi sebesar {SeranganPlasma}.");

            }
            cooldown = 2;
        }
        public void KurangiCooldown()
        {
            if (cooldown > 0)
            {
                cooldown -= 1;
            }
        }
        public bool KeteranganCooldown()
        {
            return (cooldown > 0);
        }
    }
}
