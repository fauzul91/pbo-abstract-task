using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class Perbaikan : IKemampuan
    {
        int cooldown;

        public void Gunakan(Robot pengguna, Robot target)
        {
            if (KeteranganCooldown()) // ketika skill cooldown
            {
                Console.WriteLine("Kemampuan perbaikan sedang Cooldown!");
                return;
            }

            Console.WriteLine("Robot sedang melakukan perbaikan.");
            pengguna.Energi += 20;
            cooldown = 2;
        }

        public void KurangiCooldown() // mengurangi cooldown skill giliran
        {
            if (cooldown > 0)
            {
                cooldown -= 1;
            }
        }

        public bool KeteranganCooldown() // memeriksa apakah skill cd
        {
            return cooldown > 0;
        }
    }

}
