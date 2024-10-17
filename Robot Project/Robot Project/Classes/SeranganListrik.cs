using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class SeranganListrik : IKemampuan
    {
        int cooldown;

        public void Gunakan(Robot pengguna, Robot target)
        {
            if (KeteranganCooldown())
            {
                Console.WriteLine("Kemampuan Serangan Listrik sedang cooldown!");
                return;
            }

            int seranganListrik = 20; // damage serangan listrik
            target.Energi -= seranganListrik; // mengurangi energi target
            cooldown = 3;  // set cd // skill yang lain sama
            Console.WriteLine($"Robot {pengguna.Nama} menggunakan Serangan Listrik pada {target.Nama}, mengurangi {seranganListrik} energi.");
        }

        public void KurangiCooldown() // sama
        {
            if (cooldown > 0)
            {
                cooldown -= 1;
            }
        }
        public bool KeteranganCooldown() // sama
        {
            return cooldown > 0; // Mengembalikan true jika masih dalam cooldown
        }
    }
}
