namespace TestAbility01.AbilitySystem.Abstractions.Interfaces;

public interface IAbilityBehaviour<in TActor> where TActor: IAbilityActor
{
  void ApplyBehaviour(Ability ability, TActor actorSource);
}