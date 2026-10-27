using System;
using System.Collections.Generic;
using Live2D.Cubism.Core;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainController : MonoBehaviour
{
    [field: SerializeField] public CubismModel characterModel;

    public CubismModel CharacterModel => characterModel;

    [SerializeField] List<CubismParameter> listOfModelParameters = new List<CubismParameter>();

    [SerializeField] Animator nellaAnimator;

    void Start()
    {
        InitMainController();
        InitManControllerInput();
    }
    void InitManControllerInput()
    {
        TFNovelInputActions.instance.gameInputActions.MainGameMap.OnEscape.performed += OnEscapeKey;
    }
    void InitMainController()
    {
        if (characterModel == null) characterModel = GetComponentInChildren<CubismModel>();
        foreach (var _foundParameter in characterModel.Parameters) listOfModelParameters.Add(_foundParameter);

        if (nellaAnimator == null) nellaAnimator = GetComponentInChildren<Animator>();

        // Test Function

    }

    void OnEscapeKey(InputAction.CallbackContext obj)
    {

        Debug.Log("Escape Detected");
        TriggerNextTFPhase();
    }

    void TriggerNextTFPhase()
    {
        if (nellaAnimator != null)
        {
            nellaAnimator.SetTrigger("TriggerTF");
        }
    }

    void OnDestroy()
    {
        if (TFNovelInputActions.instance != null)
        {
            TFNovelInputActions.instance.gameInputActions.MainGameMap.OnEscape.performed -= OnEscapeKey;
        }
    }
}