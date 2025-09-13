using UnityEngine;
using UnityEngine.SceneManagement; 


public class MaimMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

   
}
