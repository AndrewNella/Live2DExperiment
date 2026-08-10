using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour {

    public void StartGame () {
        SceneManager.LoadScene (1);
    }

    public void QuitGame () {
        Application.Quit ();
    }

}