using WeaponProject.Models;
namespace WeaponProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userCapacityBullet;
            int userNumBullet;
            string userShootMode;
            Console.WriteLine("Gulle tutumu:");
            userCapacityBullet = int.Parse(Console.ReadLine());
            Console.WriteLine("Gulle sayi:");
            userNumBullet = int.Parse(Console.ReadLine());
            Console.WriteLine("mode:");
            userShootMode = Console.ReadLine();
            Weapon weapon = new Weapon(userCapacityBullet, userNumBullet, userShootMode);
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("""
                0 - İnformasiya almaq üçün
                1 - Shoot metodu üçün
                2 - Fire metodu üçün
                3 - GetRemainBulletCount metodu üçün
                4 - Reload metodu üçün
                5 - ChangeFireMode metodu üçün
                6 - Proqramdan dayandırmaq üçün

                Zehmet olmasa secim edin:
                """);
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "0":
                        Console.WriteLine($"Sizin Silah atis proqrami  \nsilah tutumu: {weapon.CapacityBullet} \nsilahdaki gulle sayi: {weapon.NumBullet}  \nsizin atis mod: {weapon.ShotMode} ");
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        weapon.GetRemainBulletCount();
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                            isTrue = false;
                        break;

                }
            }
        }
    }
}
