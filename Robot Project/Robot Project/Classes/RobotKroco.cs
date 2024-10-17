using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class RobotKroco : Robot
    {
        public RobotKroco(string nama, int energi, int armor, int serangan) : base(nama, energi, armor, serangan) 
        { 
        
        }

        public override void GunakanKemampuan(IKemampuan kemampuan, Robot target)
        {
            kemampuan.Gunakan(this, target);
        }
    }
}
