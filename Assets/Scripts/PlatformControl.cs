using Unity.VisualScripting;
using UnityEngine;


public class PlatformControl : MonoBehaviour
{
    [SerializeField] private float _speed = 8f;
    
    public Joystick Stick;
    public BallControl Ball;
    
    private float _inputX;
    private Rigidbody _rb;

    private void Start()
    {
        Stick.gameObject.SetActive(true);
        _rb = GetComponent<Rigidbody>();
    }
    
    private void Update()
    {
        _inputX = Stick.Horizontal;
        
        transform.Translate(_inputX * _speed * Time.deltaTime, 0, 0);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.82f, 1.82f), transform.position.y,
            transform.position.z);
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            var paddlePosition = transform.position;
            var contactPoint = col.GetContact(0).point;
            var offset = paddlePosition.x - contactPoint.x;
            var width = col.otherCollider.bounds.size.x / 2;
            var rb = col.transform.GameObject().GetComponent<Rigidbody2D>();
            var currentAngle = Vector2.SignedAngle(Vector2.up, rb.linearVelocity);
            var bounceAngle = (offset / width) * 30;
            var newAngle = Mathf.Clamp(currentAngle + bounceAngle, -30,30);
            var rotation = Quaternion.AngleAxis(newAngle, Vector3.forward);
            rb.linearVelocity = rotation * Vector2.up * rb.linearVelocity.magnitude;
        }
    }
}


