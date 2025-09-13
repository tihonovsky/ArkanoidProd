using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigitBody;
    [SerializeField] private Text _block;
    [SerializeField] private GameObject LoseMenu;
    [SerializeField] private GameObject WinMenu;
    private int _blockCounter;
    
    void Start()
    {
        rigitBody.linearVelocity = new Vector2(3,3);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Block")) 
        {
           Destroy(col.gameObject);
           
           _blockCounter++;
           
           _block.text = _blockCounter.ToString();
        }

        if (col.gameObject.CompareTag("LoseBorder"))
        {
            LoseMenu.SetActive(true);
            
            Time.timeScale = 0f;
        }

        if (_blockCounter == 1)
        {
            WinMenu.SetActive(true);
            
            Time.timeScale = 0f;
        }
    }
   
}
