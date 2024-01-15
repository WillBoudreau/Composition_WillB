using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition_WillB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composition");
            Console.WriteLine();
            
            
            //Declaration
            //Instanstiation
            Player player = new Player();   
            Enemy enemy = new Enemy();

            Console.WriteLine("Player Health: " + player.healthsys.health);
            Console.WriteLine("Enemy health: " + enemy.healthsys.health);
            
            
            player.healthsys.TakeDamage(5);
            enemy.healthsys.TakeDamage(5);
            
            Console.WriteLine("Player Health: " + player.healthsys.health);
            Console.WriteLine("Enemy health: " + enemy.healthsys.health);

            player.healthsys.Heal(5);
            enemy.healthsys.Heal(5);

            Console.WriteLine("Player Health: " + player.healthsys.health);
            Console.WriteLine("Enemy Health: " + enemy.healthsys.health);

            Console.WriteLine("Press any key to quit");
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
