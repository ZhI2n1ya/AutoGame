using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToManeMenu : MonoBehaviour
{
    public void ClickExit()
    {
        SceneManager.LoadScene(0);
    }

    public void SelectScene(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
}
