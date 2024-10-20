using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;

namespace WeaponProject.Models
{
    internal class Weapon
    {
        public int CapacityBullet { get; set; }
        private int _numBullet;
        public int NumBullet
        {
            get
            { 
                return _numBullet;
            }
            set
            {
                
                if (value >= 0)
                {
                    _numBullet = value;
                }
                else
                {
                    Console.WriteLine("sizin daraqda gulle bitib");
                }
            }
        }
        private string _shotMode;
        public string ShotMode 
        { 
            get
            {
                return _shotMode;
            }
            set
            {
                if (value == "single" || value == "auto")
                {
                    _shotMode = value;
                }
                else
                {
                    Console.WriteLine("bu cur mod mumkun deyil");
                }
            }
        }
        public Weapon(int capacityBullet, int numBullet, string shotMode)
        {
            CapacityBullet = capacityBullet;
            NumBullet = numBullet;
            ShotMode = shotMode;
        }
        public void Shoot()
        {
            if (NumBullet > 0)
            {
                NumBullet--;
                Console.WriteLine($"emeliyyat icra olundu 1 gulle atildi. {NumBullet} / {CapacityBullet} ");
            }
            else
            {
                Console.WriteLine("sizin daraqda gulle bitib");
            }
            
        }
        public void Fire()
        {
            if (ShotMode == "auto" && NumBullet > 0)
            {
                int startNumBullet = NumBullet;

                Stopwatch fireModeTime = new Stopwatch();

                fireModeTime.Start();

                for (int i = 0; i < startNumBullet; i++)
                {
                    NumBullet--;
                }
                Thread.Sleep(2000);

                fireModeTime = new Stopwatch();

                Console.WriteLine($"{startNumBullet} eded gulle atildi. Proses {fireModeTime.ElapsedMilliseconds} millisaniye cekdi . Daraqda gulle sayi bitdi {NumBullet} / {CapacityBullet}");
            }

            else if (NumBullet <= 0)
            {
                Console.WriteLine("sizin daraqda gulle bitib");
            }

            else
            {
                Console.WriteLine("yalniz auto mod zamani ise dusur");
            }
        }
        public void GetRemainBulletCount()
        {
            int need = CapacityBullet - NumBullet;
            Console.WriteLine(need);
        }
        public void Reload()
        {
            
            
                int need = CapacityBullet - NumBullet;
                NumBullet += need;
                Console.WriteLine($" {need} gulle dolduruldu");
           
        }
        public void ChangeFireMode()
        {
            if (ShotMode == "auto")
            {
                ShotMode = "single";
                Console.WriteLine($"mod: {ShotMode}");
            }
            else if (ShotMode == "single" )
            {
                ShotMode = "auto";
                Console.WriteLine($"mod: {ShotMode}");
            }
            else
            { Console.WriteLine("bu cur mod mumkun deyil"); }
            
        }


    }
}
