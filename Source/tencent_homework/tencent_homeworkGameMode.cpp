// Copyright Epic Games, Inc. All Rights Reserved.

#include "tencent_homeworkGameMode.h"
#include "tencent_homeworkCharacter.h"
#include "UObject/ConstructorHelpers.h"

Atencent_homeworkGameMode::Atencent_homeworkGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPerson/Blueprints/BP_ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
