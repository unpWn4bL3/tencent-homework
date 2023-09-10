// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class tencent_homeworkEditorTarget : TargetRules
{
	public tencent_homeworkEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_1;
		ExtraModuleNames.Add("tencent_homework");
	}
}
