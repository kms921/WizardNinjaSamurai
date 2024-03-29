using System; 

namespace WizardNinjaSamurai 
{
    class Ninja : Human 
    {
        public Ninja (string name) : base (name)
        {
            Dexterity = 175; 
        }


        public Ninja (string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)

        {}

        public override int Attack(Human target) 

        {
            int crit = 0; 
            Random rand = new Random (); 
            if (rand.Next(1,6)==1)
            {
                crit = 10; 
            }
            int dmg = 5*Dexterity; 

            if(crit ==0)
            {
                target.Health -= dmg; 
                System.Console.WriteLine($"{Name} snuck up and attacked {target.Name}"); 
            }
            return target.Health; 
        }

        public void Steal(Human target)
        {
            target.Health -= 5; 
            if (Health < maxHP -5)
            {
                Health +=5; 
            }
            else 
            Health = maxHP; 

        }
    }


}
