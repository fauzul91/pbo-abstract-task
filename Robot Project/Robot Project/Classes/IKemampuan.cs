using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public interface IKemampuan
    {
        void Gunakan(Robot pengguna, Robot target);
        void KurangiCooldown();

        bool KeteranganCooldown();
    }
}
