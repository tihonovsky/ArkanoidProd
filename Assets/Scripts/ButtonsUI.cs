using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonsUI : MonoBehaviour
{
    [SerializeField] private PlatformControl _platformControl;
    [SerializeField] private GameObject _startWindow;
    [SerializeField] private GameObject _loseWindow;
    [SerializeField] private GameObject _victoryWindow;
    [SerializeField] private GameObject _pauseWindow;
    
    private bool _pauseGame;
    
    public void Pause()
    {
        _pauseWindow.SetActive(true);
        
        _pauseGame = true;
        
        Time.timeScale = 0f;
        
        _platformControl.Joystick.gameObject.SetActive(false);
    }

    public void Resume()
    {
        _pauseWindow.SetActive(false);
        
        Time.timeScale = 1f;
        
        _pauseGame = false;
        
        _platformControl.Joystick.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene(currentSceneIndex);
        
        Time.timeScale = 1f;
    }

    public void LoadStartWindow()
    {
        Time.timeScale = 1f;
        
        SceneManager.LoadScene("StartWindow");
    }
    
    

   

   
    
   
    
    
}












