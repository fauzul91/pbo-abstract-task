using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class Perbaikan : IKemampuan
    {
        public int Cooldown { get; set; }
        public int MaxCooldown { get; } = 7;  

        public void Gunakan(Robot pengguna, Robot target) { }

        public void Gunakan(Robot pengguna)
        {
            Console.WriteLine($"{pengguna.Nama} menggunakan Perbaikan!");
            pengguna.Energi += 20;
            Console.WriteLine($"{pengguna.Nama} memulihkan energi! Energi sekarang: {pengguna.Energi}");
        }
    }
}
