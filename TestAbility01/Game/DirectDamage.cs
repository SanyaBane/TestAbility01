using TestAbility01.AbilitySystem;
using TestAbility01.AbilitySystem.Abstractions.Interfaces;

namespace TestAbility01.Game;

public class DirectDamage : AbilityBehaviour
{
  public override void ApplyBehaviour(Ability ability, IAbilityActor actorSource)
  {
    Console.WriteLine($"Execute DirectDamage behaviour using ability {ability.AbilityName} by {actorSource.Name}");
  }
}