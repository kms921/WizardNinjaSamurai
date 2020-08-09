using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Wizard elsa = new Wizard ("elsa"); 
            Wizard harry = new Wizard ("harry"); 
            Ninja ken  = new Ninja ("ken"); 

            ken.Attack(elsa); 
            elsa.Attack(harry);
            harry.Heal(elsa); 
            
        }
    }
}
