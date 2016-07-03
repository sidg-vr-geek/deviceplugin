#include "DevicePluginPrivatePCH.h"
#include "stdio.h"

void PluginLogger::LogI(char *caller, char *msg)
{
	FString FsCaller = FString(ANSI_TO_TCHAR(caller));
	FString FsMsg    = FString(ANSI_TO_TCHAR(msg));
	UE_LOG(LogTemp, Warning, TEXT("Module loaded"));
}