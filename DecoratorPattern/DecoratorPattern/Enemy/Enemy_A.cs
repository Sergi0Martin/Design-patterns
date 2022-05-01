using System;

namespace Pruebas_ConsoleApp
{
    public class Enemy_A : Enemy
    {
        public override int Life { get; set; }

        public const int protectionBase = 10;

        public Enemy_A(int life)
        {
            Life = life;
        }

        public override int computeDamage(int recivedDamage)
        {
            Console.WriteLine("Bloqueo base:" + protectionBase);

            return recivedDamage - protectionBase;
        }
    }
}
