using System;

namespace Pruebas_ConsoleApp
{
    public class HelmetDecorator : EnemyDecorator
    {
        private Enemy decoratedEnemy;

        public override int Life { get => decoratedEnemy.Life; set => decoratedEnemy.Life = value; }

        private const int HelmetProtection = 30;

        public HelmetDecorator(Enemy enemyToDecorate)
        {
            decoratedEnemy = enemyToDecorate;
        }

        public override int computeDamage(int recivedDamage)
        {
            recivedDamage = decoratedEnemy.computeDamage(recivedDamage);
            Console.WriteLine("Bloqueas con HelmetProtection:" + HelmetProtection);

            return recivedDamage - HelmetProtection;
        }
    }
}
