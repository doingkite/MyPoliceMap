// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MyPolice : ModuleRules
{
	public MyPolice(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MyPolice",
			"MyPolice/Variant_Platforming",
			"MyPolice/Variant_Platforming/Animation",
			"MyPolice/Variant_Combat",
			"MyPolice/Variant_Combat/AI",
			"MyPolice/Variant_Combat/Animation",
			"MyPolice/Variant_Combat/Gameplay",
			"MyPolice/Variant_Combat/Interfaces",
			"MyPolice/Variant_Combat/UI",
			"MyPolice/Variant_SideScrolling",
			"MyPolice/Variant_SideScrolling/AI",
			"MyPolice/Variant_SideScrolling/Gameplay",
			"MyPolice/Variant_SideScrolling/Interfaces",
			"MyPolice/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
