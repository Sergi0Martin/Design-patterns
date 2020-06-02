namespace Pruebas_ConsoleApp
{
    public abstract class Enemy
    {
        abstract public int Life { get; set; }

        public virtual int computeDamage(int recivedDamage)
        {
            return recivedDamage;
        }
    }
}
