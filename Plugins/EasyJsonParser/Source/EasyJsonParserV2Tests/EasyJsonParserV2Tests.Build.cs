// Copyright 2025 ayumax. All Rights Reserved.

using UnrealBuildTool;

public class EasyJsonParserV2Tests : ModuleRules
{
	public EasyJsonParserV2Tests(ReadOnlyTargetRules Target) : base(Target)
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
		
		PublicIncludePaths.AddRange(
			new string[] {
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"EasyJsonParser",
				"EasyJsonParserV2"
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"Json",
				"FunctionalTesting",
				"AutomationController"
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
			}
			);
	}
}