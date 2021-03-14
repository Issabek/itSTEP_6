using System;

namespace WorldOfTanks
{
    public abstract class Tank
    {
        public int Ammunition { get; set; }
        public int Armour { get; set; }
        public int Mobility { get; set; }
        public string Name { get; set; }

        public string ShowInfo()
        {
            return string.Format("Tank name: {0};\nAmmunition status: {1}%;\nArmour status: {2}%;\nMobility status: {3}%;", Name, Ammunition, Armour, Mobility); ;
        }

        public static bool operator <(Tank someTank, Tank otherTank)
        {
            int result = ((someTank.Mobility - otherTank.Mobility) > 0 ? 1 : -1) + ((someTank.Armour - otherTank.Armour) > 0 ? 1 : -1) + ((someTank.Ammunition - otherTank.Ammunition) > 0 ? 1 : -1);
            if (result > 0)
                return false;
            else
                return true;
        }

        public static bool operator >(Tank someTank, Tank otherTank)
        { 
            int result = ((someTank.Mobility - otherTank.Mobility) > 0 ? 1 : -1) + ((someTank.Armour - otherTank.Armour) > 0 ? 1 : -1) + ((someTank.Ammunition - otherTank.Ammunition) > 0 ? 1 : -1);
            if (result > 0)
                return true;
            else
                return false;
        }

        public static Tank operator ^(Tank someTank, Tank otherTank)
        {
            if (someTank.Name == null || otherTank.Name==null)
            {
                throw new Exception("Tank's \"Name\" property cannot be null or empty");
            }
            else
            {
                if (someTank > otherTank)
                    return someTank;
                else
                    return otherTank;
            }
        }
    }

    public class T34 : Tank
    {
        public T34()
        {
            Random rnd = new Random();
            Ammunition = rnd.Next(50,100);
            Armour = rnd.Next(50,100);
            Mobility = rnd.Next(50,100);
        }

        public T34(string Name) : this()
        {
            this.Name = Name;
        }
    }

    public class PANTHER : Tank
    {
        public PANTHER()
        {
            Random rnd = new Random();
            Ammunition = rnd.Next(50,100);
            Armour = rnd.Next(50,100);
            Mobility = rnd.Next(50,100);
        }

        public PANTHER(string Name) : this()
        {
            this.Name = Name;
        }
    }

}
