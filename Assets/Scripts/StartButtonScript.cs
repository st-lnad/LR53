using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Game");
        SceneManager.UnloadSceneAsync("Tutorial");
    }
}
