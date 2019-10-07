using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COTGH.game.puzzle
{
  public class Difficulty
  {
    public enum Level
    {
      DEBUG,
      EASY,
      MEDIUM,
      HARD,
    }

    public static bool IsInternal(in Level level) => level == Level.DEBUG;
  }
}
