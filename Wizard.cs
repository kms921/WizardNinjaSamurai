using System; 

namespace WizardNinjaSamurai 
{

    class Wizard : Human
    {
        public Wizard (string name) : base (name)
        {
            Intelligence = 25; 
            maxHP = 50; 
            Health = maxHP; 
        }

        public Wizard (string name, int str, int intel, int dex, int hp ) : base (name, str, intel, dex, hp)
        {
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence *5; 
            target.Health -= dmg; 
            Health += dmg; 
            if (Health >maxHP)
            {
                Health = maxHP; 
            }
            return target.Health; 

        }

        public void Heal(Human target)
        {
            int hp = 10 * Intelligence; 
            System.Console.WriteLine($"{Name} healed {target.Name}");

            target.Health+= hp; 
        }

    }

}