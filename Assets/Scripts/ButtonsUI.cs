using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonsUI : MonoBehaviour
{
    [SerializeField] private PlatformControl _platformControl;
    
    public GameObject PauseMenu;
    
    private bool _pauseGame;
    
    public void Pause()
    {
        PauseMenu.SetActive(true);
        
        _pauseGame = true;
        
        Time.timeScale = 0f;
        
        _platformControl.Stick.gameObject.SetActive(false);
    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        
        Time.timeScale = 1f;
        
        _pauseGame = false;
        
        _platformControl.Stick.gameObject.SetActive(true);
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
        
        _platformControl.Stick.gameObject.SetActive(false);
    }
    
    
}












