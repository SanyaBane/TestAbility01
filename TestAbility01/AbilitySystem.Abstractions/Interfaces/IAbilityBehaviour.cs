namespace TestAbility01.AbilitySystem.Abstractions.Interfaces;

public interface IAbilityBehaviour
{
  void ApplyBehaviour(Ability ability, IAbilityActor actorSource);
}