// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EasyJsonParser : ModuleRules
{
	public EasyJsonParser(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bEnableExceptions = true;

		PublicDependencyModuleNames.Add("Core");
		
		PrivateDependencyModuleNames.AddRange(new string[]{
			"CoreUObject",
			"Engine",
			"Slate",
			"SlateCore",
			"Json"
		});
	}
}
