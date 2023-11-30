using TestAbility01.AbilitySystem;
using TestAbility01.Game;

namespace TestAbility01
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      var actor = new Actor("Alex");
      
      var behaviours = new List<AbilityBehaviour>();
      
      var damageBehaviour = AbilityBehavioursFactory.CreateBehaviour("Damage");
      behaviours.Add(damageBehaviour);

      var ability = new Ability(actor, "Fireball", behaviours);
      ability.Execute();

      Console.ReadLine();
    }
  }
}