using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class SeranganPlasma : IKemampuan
    {
        public int Cooldown { get; set; }
        public int MaxCooldown { get; } = 4;  

        public void Gunakan(Robot pengguna, Robot target)
        {
            Console.WriteLine($"{pengguna.Nama} menggunakan Serangan Plasma pada {target.Nama}!");
            int damage = pengguna.Serangan * 2;
            target.Energi -= damage;
            Console.WriteLine($"{target.Nama} terkena serangan plasma! Energi tersisa: {target.Energi}");
        }

        public void Gunakan(Robot pengguna) { }        
    }
}
