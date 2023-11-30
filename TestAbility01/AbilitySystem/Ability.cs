using TestAbility01.AbilitySystem.Abstractions.Interfaces;

namespace TestAbility01.AbilitySystem;

public class Ability
{
  private readonly IAbilityActor _actor;
  private readonly List<AbilityBehaviour> _abilityBehaviours;

  public Ability(IAbilityActor actor, string abilityName, List<AbilityBehaviour> abilityBehaviours)
  {
    _actor = actor;
    AbilityName = abilityName;
    _abilityBehaviours = abilityBehaviours;
  }

  public string AbilityName { get; }

  public void Execute()
  {
    foreach (var abilityBehaviour in _abilityBehaviours)
    {
      abilityBehaviour.ApplyBehaviour(this, _actor);
    }
  }
}