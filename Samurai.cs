using System; 

namespace WizardNinjaSamurai 
{

    class Samurai : Human
    {

        public Samurai(string name) : base(name)
        {
            maxHP =200; 
            Health = maxHP; 

        }

        public Samurai (string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)

        {
        }

        public override int Attack(Human target)
        {
            int remaining = base.Attack(target); 

            if (remaining < 50 ) 
            {
                target.Health = 0; 
            }
            System.Console.WriteLine($"never saw it coming"); 
            return target.Health; 
        }

        public void Meditate (Human target)
        {
            Health = MaxHP; 
            System.Console.WriteLine($"{Name} meditated and saved {target}");
        }
    }
}