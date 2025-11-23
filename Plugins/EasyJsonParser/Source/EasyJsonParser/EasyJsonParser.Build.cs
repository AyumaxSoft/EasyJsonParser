// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EasyJsonParser : ModuleRules
{
	public EasyJsonParser(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		// Relax some Clang enum-conversion related warnings which became stricter in UE5.7 CI environments
		// These settings only affect toolchains that support the corresponding flags (primarily Clang/Apple/Linux)
		CppCompileWarningSettings.ShadowVariableWarningLevel = WarningLevel.Warning;
		CppCompileWarningSettings.EnumConversionWarningLevel = WarningLevel.Off; // -Wno-enum-conversion
		CppCompileWarningSettings.ClangBitfieldEnumConversion = WarningLevel.Off; // -Wno-bitfield-enum-conversion
		CppCompileWarningSettings.EnumEnumConversionWarningLevel = WarningLevel.Off; // -Wno-enum-enum-conversion
		CppCompileWarningSettings.EnumFloatConversionWarningLevel = WarningLevel.Off; // -Wno-enum-float-conversion


		// Enable exceptions for proper error handling
		bEnableExceptions = true;

		PublicDependencyModuleNames.Add("Core");

		PrivateDependencyModuleNames.AddRange(new[]
		{
			"CoreUObject",
			"Engine",
			"Slate",
			"SlateCore",
			"Json"
		});
	}
}