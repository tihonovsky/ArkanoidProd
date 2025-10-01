using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;


public class BallControl : MonoBehaviour
{
    [SerializeField] private PlatformControl _platformControl;
    [SerializeField] public Rigidbody2D _rigitBody;
    [SerializeField] private Text _block;
    [SerializeField] private GameObject _loseWindow;
    [SerializeField] private GameObject _victoryWindow;
    [SerializeField] private Sprite _damageSprite;
    
    
    
    public float BallSpeed;
    public bool IsActiveBall;
    
    private int _blockCounter;
    
    private void Start()
    {
        
        _rigitBody = GetComponent<Rigidbody2D>();
        _rigitBody.bodyType = RigidbodyType2D.Kinematic;
    }
    
    public void BallActivate()
    {
        IsActiveBall = true;
        _rigitBody.bodyType = RigidbodyType2D.Dynamic;
        _rigitBody.linearVelocity = new Vector2(0,BallSpeed);
    }
    
    public void OnCollisionEnter2D(Collision2D coll)
    {
        Image img = coll.gameObject.GetComponent<Image>();
        if (coll.gameObject.CompareTag("Block")) 
        {
            Destroy(coll.gameObject);
           
            _blockCounter++;
           
            _block.text = _blockCounter.ToString();
            
        }

        if (coll.gameObject.CompareTag("Block2"))
        {
            coll.gameObject.tag = "Block";
            img.sprite = _damageSprite;
        }

        if (coll.gameObject.CompareTag("LoseBorder"))
        {
            _loseWindow.SetActive(true);
            
            Time.timeScale = 0f;
            
            _platformControl.Joystick.gameObject.SetActive(false);
        }

        if (_blockCounter == 13)
        {
            _victoryWindow.SetActive(true);
            
            Time.timeScale = 0f;
            
            _platformControl.Joystick.gameObject.SetActive(false);
        }
    }
   
}
