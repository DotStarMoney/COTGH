using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGH.game.puzzle
{
  class BookTitlePuzzle
  {
    ActionType Action { get; }
    ModifierType Modifier { get; }
    int ModifierValue { get; }
    Location Location { get; }
    List<string> Titles { get; }

    public enum ActionType
    {
      WAIT,
      JUMP,
      CROUCH,
      ACTIVATE
    };

    public enum ModifierType
    {
      NONE,
      DELAY_SEC,
      REPETITION
    };

    private BookTitlePuzzle(
        in ActionType action, 
        in ModifierType modifier, 
        in int modifierValue, 
        in Location location, 
        in List<string> titles)
    {
      this.Action = action;
      this.Modifier = modifier;
      this.ModifierValue = modifierValue;
      this.Location = location;
      this.Titles = titles;
    }

    public static BookTitlePuzzle create(Difficulty.Level level, Layout layout)
    {
      var (location, isActivatable) = layout.GetRandomPointOfInterest();


      return new BookTitlePuzzle();
    }
  }
}
