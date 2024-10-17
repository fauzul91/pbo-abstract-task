using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class SeranganListrik : IKemampuan
    {
        public int Cooldown { get; set; }
        public int MaxCooldown { get; } = 2;

        public void Gunakan(Robot pengguna, Robot target)
        {
            Console.WriteLine($"{pengguna.Nama} menggunakan Serangan Listrik pada {target.Nama}!");
            target.Energi -= 30;
            Console.WriteLine($"{target.Nama} terkena serangan listrik! Energi tersisa: {target.Energi}");
        }

        public void Gunakan(Robot pengguna) { }
    }
}
