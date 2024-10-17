using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class BosRobot : Robot
    {
        public BosRobot(string nama) : base(nama, 180, 10, 25) { }

        public override void GunakanKemampuan(IKemampuan kemampuan, Robot target)
        {
            if (kemampuan.Cooldown == 0)
            {
                kemampuan.Gunakan(this, target);
                kemampuan.Cooldown = kemampuan.MaxCooldown;  
            }
            else
            {
                Console.WriteLine($"{Nama} tidak dapat menggunakan {kemampuan.GetType().Name}, cooldown tersisa {kemampuan.Cooldown} giliran.");
            }
        }

        public override void GunakanKemampuan(IKemampuan kemampuan)
        {
            if (kemampuan.Cooldown == 0)
            {
                kemampuan.Gunakan(this);
                kemampuan.Cooldown = kemampuan.MaxCooldown;  
            }
            else
            {
                Console.WriteLine($"{Nama} tidak dapat menggunakan {kemampuan.GetType().Name}, cooldown tersisa {kemampuan.Cooldown} giliran.");
            }
        }

        public void Mati()
        {
            Console.WriteLine($"{Nama} telah mati!");
        }
    }
}
