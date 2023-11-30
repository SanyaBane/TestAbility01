using TestAbility01.AbilitySystem.Abstractions.Interfaces;

namespace TestAbility01.AbilitySystem;

public abstract class AbilityBehaviour
{
  protected AbilityBehaviour(string behaviourName)
  {
    BehaviourName = behaviourName;
  }
  
  public string BehaviourName { get; }
  
  public abstract void ApplyBehaviour(Ability ability, IAbilityActor actorSource);
}