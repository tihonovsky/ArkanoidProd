using UnityEngine;



public class PlatformControl : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    
    void Update()
    {
        transform.Translate(speed * Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.82f, 1.82f), transform.position.y, transform.position.z);
    }
}


