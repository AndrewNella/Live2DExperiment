using System.Collections.Generic;
using Live2D.Cubism.Core;
using UnityEngine;

public class MainController : MonoBehaviour {
    [field: SerializeField] public CubismModel characterModel;

    public CubismModel CharacterModel => characterModel;

    [SerializeField] List<CubismParameter> listOfModelParameters = new List<CubismParameter> ();

    void Start () {
        if (characterModel == null) characterModel = GetComponentInChildren<CubismModel> ();
        foreach (var _foundParameter in characterModel.Parameters) listOfModelParameters.Add (_foundParameter);
    }

}