using UnrealBuildTool;

public class Social_DetectiveTarget : TargetRules
{
	public Social_DetectiveTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Social_Detective");
	}
}
