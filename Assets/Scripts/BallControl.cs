using UnityEngine;
using UnityEngine.UI;


public class BallControl : MonoBehaviour
{
    [SerializeField] private PlatformControl _platformControl;
    [SerializeField] public Rigidbody2D _rigitBody;
    [SerializeField] private Text _block;
    [SerializeField] private GameObject _loseMenu;
    [SerializeField] private GameObject _victoryMenu; 
    
    public float BallSpeed;
    
    private int _blockCounter;
    private bool _isActiveBall;
    
    private void Start()
    {
        _rigitBody = GetComponent<Rigidbody2D>();
        _rigitBody.bodyType = RigidbodyType2D.Kinematic;
    }

    private void Update()
    {
        if (_platformControl.transform.position.x != 0 && !_isActiveBall)
        {
            BallActivate();
        }
    }

    private void BallActivate()
    {
        _isActiveBall = true;
        _rigitBody.bodyType = RigidbodyType2D.Dynamic;
        _rigitBody.linearVelocity = new Vector2(0,BallSpeed);
    }
    

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Block")) 
        {
           Destroy(coll.gameObject);
           
           _blockCounter++;
           
           _block.text = _blockCounter.ToString();
        }

        if (coll.gameObject.CompareTag("LoseBorder"))
        {
            _loseMenu.SetActive(true);
            
            Time.timeScale = 0f;
            
            _platformControl.Stick.gameObject.SetActive(false);
        }

        if (_blockCounter == 21)
        {
            _victoryMenu.SetActive(true);
            
            Time.timeScale = 0f;
            
            _platformControl.Stick.gameObject.SetActive(false);
        }
    }
   
}
