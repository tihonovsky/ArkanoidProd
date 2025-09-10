using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigitBody;
    void Start()
    {
        rigitBody.linearVelocity = new Vector2(3,3);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Block")) 
        {
           Destroy(col.gameObject);
        }
    }
   
}
