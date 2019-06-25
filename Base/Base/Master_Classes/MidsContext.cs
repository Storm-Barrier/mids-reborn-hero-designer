
using Base.Data_Classes;

namespace Base.Master_Classes
{
  public static class MidsContext
  {
    public static int MathLevelBase = 49;
    public static int MathLevelExemp = -1;
    public const float AppVersion = 1.962f;
    public const string AppName = "Mids' Hero Designer";
    public static Archetype Archetype;
    public static Character Character;

    public static ConfigData Config
    {
      get
      {
        return ConfigData.Current;
      }
    }
  }
}