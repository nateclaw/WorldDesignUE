// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class WorldDesignUE : ModuleRules
{
	public WorldDesignUE(ReadOnlyTargetRules Target) : base(Target)
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
			"WorldDesignUE",
			"WorldDesignUE/Variant_Platforming",
			"WorldDesignUE/Variant_Platforming/Animation",
			"WorldDesignUE/Variant_Combat",
			"WorldDesignUE/Variant_Combat/AI",
			"WorldDesignUE/Variant_Combat/Animation",
			"WorldDesignUE/Variant_Combat/Gameplay",
			"WorldDesignUE/Variant_Combat/Interfaces",
			"WorldDesignUE/Variant_Combat/UI",
			"WorldDesignUE/Variant_SideScrolling",
			"WorldDesignUE/Variant_SideScrolling/AI",
			"WorldDesignUE/Variant_SideScrolling/Gameplay",
			"WorldDesignUE/Variant_SideScrolling/Interfaces",
			"WorldDesignUE/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
