using System;
using System.Collections.Generic;
using Live2D.Cubism.Core;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainController : MonoBehaviour {
    [field: SerializeField] public CubismModel characterModel;

    public CubismModel CharacterModel => characterModel;

    [SerializeField] List<CubismParameter> listOfModelParameters = new List<CubismParameter> ();

    [SerializeField] Animator nellaAnimator;

    void Start () {
        if (characterModel == null) characterModel = GetComponentInChildren<CubismModel> ();
        foreach (var _foundParameter in characterModel.Parameters) listOfModelParameters.Add (_foundParameter);

        if (nellaAnimator == null) nellaAnimator = GetComponentInChildren<Animator> ();


        // Test Function
        InputActionInstance.instance.gameInputActions.MainGameMap.OnEscape.performed += OnTF;
    }

    void OnTF (InputAction.CallbackContext obj) {

        Debug.Log ("Escape Detected");
        if (nellaAnimator != null) {
            nellaAnimator.SetTrigger ("TriggerTF");
        }
    }

    void OnDestroy () {
        InputActionInstance.instance.gameInputActions.MainGameMap.OnEscape.performed -= OnTF;
    }
}