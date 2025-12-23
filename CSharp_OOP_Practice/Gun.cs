using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Practice
{
    internal class Gun
    {
        private int _ammo;
        private int _clipsSize;

        public Gun (int ammo, int clips_size)
        {
            _ammo = ammo;
            _clipsSize = clips_size;
        }

        public void Shoot()
        {
            if (_ammo > 0)
            {
                Console.WriteLine("Бах!");
                _ammo--;
            }
            else
            {
                Console.WriteLine("Клац, кончились патроны!");
            }
        }

        public int AmmoCount { get { return _ammo; } }

        public void Reload()
        {
            _ammo = _clipsSize;
            Console.WriteLine($"Перезарядка... Теперь патронов: {_ammo}");
        }
    }
}
