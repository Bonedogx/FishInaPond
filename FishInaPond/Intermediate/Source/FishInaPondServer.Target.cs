using UnrealBuildTool;

public class FishInaPondServerTarget : TargetRules
{
	public FishInaPondServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("FishInaPond");
	}
}
