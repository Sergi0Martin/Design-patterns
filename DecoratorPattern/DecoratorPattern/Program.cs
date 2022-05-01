using System;

namespace Pruebas_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Enemy enemyA = new Enemy_A(500);
            enemyA = new HelmetDecorator(enemyA);
            Console.WriteLine("Vida inicial: " + enemyA.Life);

            var damage = 70;
            Console.WriteLine("Daño total a recibir: " + damage);

            var damageRecived = enemyA.computeDamage(damage);
            enemyA.Life -= damageRecived;

            Console.WriteLine("Daño Recivido: " + damageRecived + ". Vida resultante: " + enemyA.Life);

            // Ejemplo en : https://danielggarcia.wordpress.com/2014/03/10/patrones-estructurales-iii-patron-decorator/comment-page-1/

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
