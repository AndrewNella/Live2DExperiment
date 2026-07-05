using UnityEngine;

public class InputActionInstance : MonoBehaviour {

    public static InputActionInstance instance;

    [field: SerializeField] public GameInputs gameInputActions { get; private set; }

    void Awake () {
        if (instance == null) instance = this;

        gameInputActions = new GameInputs ();
        gameInputActions.Enable ();
    }

  
}