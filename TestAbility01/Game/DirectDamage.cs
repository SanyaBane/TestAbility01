﻿using TestAbility01.AbilitySystem;
using TestAbility01.AbilitySystem.Abstractions.Interfaces;

namespace TestAbility01.Game;

public class DirectDamage : AbilityBehaviour, IAbilityBehaviour
{
  public DirectDamage(string behaviourName) : base(behaviourName)
  {
  }

  public void ApplyBehaviour(Ability ability, IAbilityActor actorSource)
  {
    Console.WriteLine($"Execute behaviour with name '{BehaviourName}' of type '{GetType().Name}' using ability {ability.AbilityName} by {actorSource.Name}");
  }
}