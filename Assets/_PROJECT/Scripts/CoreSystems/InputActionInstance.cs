using UnityEngine;

public class TFNovelInputActions : MonoBehaviour
{

    public static TFNovelInputActions instance;

    [field: SerializeField] public GameInputs gameInputActions { get; private set; }

    void Awake()
    {
        if (instance == null) instance = this;

        gameInputActions = new GameInputs();
        gameInputActions.Enable();
    }


}