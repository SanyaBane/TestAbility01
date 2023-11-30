namespace TestAbility01.AbilitySystem;

public abstract class AbilityBehaviour
{
  protected AbilityBehaviour(string behaviourName)
  {
    BehaviourName = behaviourName;
  }
  
  public string BehaviourName { get; }
}