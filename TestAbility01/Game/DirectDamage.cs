using TestAbility01.AbilitySystem;
using TestAbility01.AbilitySystem.Abstractions.Interfaces;
using TestAbility01.Game.Abstractions.Interfaces;

namespace TestAbility01.Game;

public class DirectDamage : AbilityBehaviour, IAbilityBehaviour<IActor>
{
  public DirectDamage(string behaviourName) : base(behaviourName)
  {
  }

  public void ApplyBehaviour(Ability ability, IActor actorSource)
  {
    Console.WriteLine($"Execute behaviour with name '{BehaviourName}' of type '{GetType().Name}' using ability {ability.AbilityName} by {actorSource.Name}");
  }
}