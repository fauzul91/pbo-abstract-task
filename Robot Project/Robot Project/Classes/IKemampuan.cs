using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public interface IKemampuan
    {
        int Cooldown { get; set; }
        int MaxCooldown { get; }
        void Gunakan(Robot pengguna, Robot target);
        void Gunakan(Robot pengguna);
    }
}
