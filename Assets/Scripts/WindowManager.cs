using UnityEngine;
using UnityEngine.SceneManagement; 


public class WindowManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevelWindow()
    {
        SceneManager.LoadScene("LevelWindow");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
    }

   
}
