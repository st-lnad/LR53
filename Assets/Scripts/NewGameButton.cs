using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Tutorial");
        SceneManager.UnloadSceneAsync("MainMenu");
    }
}
