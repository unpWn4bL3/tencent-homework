// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class tencent_homework : ModuleRules
{
	public tencent_homework(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}
