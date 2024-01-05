using BepInEx;
using RoR2;

namespace VieldsInc;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]

public class Main : BaseUnityPlugin
{
  public const string PluginGUID = PluginAuthor + "." + PluginName;
  public const string PluginAuthor = "MarkTullius";
  public const string PluginName = "VoidFieldsStageIncrement";
  public const string PluginVersion = "1.0.0";

  private static readonly SceneType TimedIntermission = (SceneType)4;

  public void Awake()
  {
    On.RoR2.Run.AdvanceStage += (orig, self, nextScene) =>
    {
      orig(self, nextScene);
      if (SceneCatalog.GetSceneDefForCurrentScene().sceneType == TimedIntermission)
      {
        self.NetworkstageClearCount = self.stageClearCount + 1;
      }
    };
  }
}