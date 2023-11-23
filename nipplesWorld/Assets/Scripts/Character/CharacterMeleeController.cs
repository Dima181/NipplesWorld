using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class CharacterMeleeController : MeleeAttack
{
    [Inject] private CharacterInputController characterInputController { get; set; }

    private void Update()
    {
        var controllerInput = characterInputController.InputButtonCheckMelee();
        Attack();
    }
}
