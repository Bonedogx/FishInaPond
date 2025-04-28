using UnrealBuildTool;

public class FishInaPondClientTarget : TargetRules
{
	public FishInaPondClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("FishInaPond");
	}
}
