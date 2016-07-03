// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using System.IO;

namespace UnrealBuildTool.Rules
{
	public class MDevicePlugin : ModuleRules
    {
        private string ModulePath
        {
            get { return Path.GetDirectoryName(RulesCompiler.GetModuleFilename(this.GetType().Name)); }
        }

        private string ThirdPartyPath
        {
            get { return Path.GetFullPath(Path.Combine(ModulePath, "../../ThirdParty/")); }
        }

		public MDevicePlugin(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(
				new string[]    {
                                    "../DevicePlugin/Public",
                                }
				);

			PrivateIncludePaths.AddRange(
                new string[]    {
                                    "../DevicePlugin/Private",
				                }
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				                {
					                "Core",
                                    "CoreUObject",
                                    "Engine"
				                }
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				                {
				                }
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);

            LoadDriverLibrary(Target);
		}

        public void LoadDriverLibrary(TargetInfo Target)
        {
            string LibrariesPath = Path.Combine(ThirdPartyPath, "DeviceDriver", "Libraries");
            string IncludesPath  = Path.Combine(ThirdPartyPath, "DeviceDriver", "Includes");

            PublicAdditionalLibraries.Add(Path.Combine(LibrariesPath, "DeviceDriverConsole32.lib"));
            PublicIncludePaths.Add(IncludesPath);
        }
	}
}