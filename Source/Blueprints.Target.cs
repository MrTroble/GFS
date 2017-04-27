// GNU Public License

using UnrealBuildTool;
using System.Collections.Generic;

public class BlueprintsTarget : TargetRules
{
	public BlueprintsTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
	}

	//
	// TargetRules interface.
	//

	public override void SetupBinaries(
		TargetInfo Target,
		ref List<UEBuildBinaryConfiguration> OutBuildBinaryConfigurations,
		ref List<string> OutExtraModuleNames
		)
	{
		OutExtraModuleNames.AddRange( new string[] { "Blueprints" } );
	}
}
