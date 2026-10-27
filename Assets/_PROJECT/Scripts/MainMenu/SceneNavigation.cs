using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{

    public static SceneNavigation instance;


    private void Awake()
    {
        instance = this;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }

}