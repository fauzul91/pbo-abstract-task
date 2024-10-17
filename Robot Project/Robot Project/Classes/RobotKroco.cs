using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class RobotKroco : Robot
    {
        public RobotKroco(string nama) : base(nama, 120, 5, 30) { }

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
    }
}
