using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class PertahananSuper : IKemampuan
    {
        int cooldown;

        public void Gunakan(Robot pengguna, Robot target)
        {
            if (cooldown > 0)
            {
                Console.WriteLine("Kemampuan Pertahanan Super Sedang Cooldown!");
                return;
            }
            Console.WriteLine("Robot sedang melakukan Pertahanan Super.");
            pengguna.Armor += 20;
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
