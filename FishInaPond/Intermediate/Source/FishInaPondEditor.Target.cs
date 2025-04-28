using UnrealBuildTool;

public class FishInaPondEditorTarget : TargetRules
{
	public FishInaPondEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("FishInaPond");
	}
}
