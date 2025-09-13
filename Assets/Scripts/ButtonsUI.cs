using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonsUI : MonoBehaviour
{
    private bool PauseGame;
    
    public GameObject PauseMenu;
    

    public void Pause()
    {
        PauseMenu.SetActive(true);
        PauseGame = true;
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }
    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1f;
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainManu");
    }
    
    
}