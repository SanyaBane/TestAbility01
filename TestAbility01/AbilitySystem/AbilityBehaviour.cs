using TestAbility01.AbilitySystem.Abstractions.Interfaces;

namespace TestAbility01.AbilitySystem;

public abstract class AbilityBehaviour
{
  public abstract void ApplyBehaviour(Ability ability, IAbilityActor actorSource);
}