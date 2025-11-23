// // Copyright (c) 2020 ayuma_x. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using UnrealBuildTool;

public class EasyJsonParserTests : ModuleRules
{
	public EasyJsonParserTests
		(ReadOnlyTargetRules Target) : base(Target)
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

		PublicDependencyModuleNames.AddRange(
			new[]
			{
				"Core",
				"CoreUObject",
				"Engine",
				"InputCore"
			}
		);

		PrivateDependencyModuleNames.AddRange(
			new[]
			{
				"EasyJsonParser",
				"AutomationController",
				"FunctionalTesting"
			}
		);

		if (Target.bBuildEditor)
		{
			PrivateDependencyModuleNames.Add("UnrealEd");
			PrivateDependencyModuleNames.Add("EditorStyle");
		}
	}
}