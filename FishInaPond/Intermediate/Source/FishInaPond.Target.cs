using UnrealBuildTool;

public class FishInaPondTarget : TargetRules
{
	public FishInaPondTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FishInaPond");
	}
}
