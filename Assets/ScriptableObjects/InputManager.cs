using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "InputManager")]
public class InputManager : ScriptableObject
{
    Controles controles;

    public event Action OnAttackAction;
    public event Action OnDodgeAction;

    private void OnEnable()
    {
        //Constructor.
        controles = new Controles();

        controles.Gameplay.Enable();

        //Suscripciones a eventos.
        controles.Gameplay.Attack.started += OnAttack;
        controles.Gameplay.Dodge.started += OnDodge;
    }

    private void OnDodge(InputAction.CallbackContext obj)
    {
        OnDodgeAction?.Invoke();
    }

    private void OnAttack(InputAction.CallbackContext obj)
    {
        OnAttackAction?.Invoke();
    }
}