using TestAbility01.AbilitySystem.Abstractions.Interfaces;
using TestAbility01.Game.Abstractions.Interfaces;

namespace TestAbility01.Game;

public static class AbilityBehavioursFactory
{
  public static IAbilityBehaviour<IActor> CreateBehaviour(string behaviourId)
  {
    switch (behaviourId)
    {
      case "Damage":
        return new DirectDamage("damage");
      default:
        throw new NotSupportedException();
    }
  }
}