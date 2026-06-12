using UnityEngine;

public class Player : MonoBehaviour
{
    
    private float speed = 15f, hspeed = 15f;
    private Rigidbody rb;


    private void Update()
    {

        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed * v);

        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * hspeed * h);
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(v, 1f, h) * speed * Time.fixedDeltaTime);
    }

}
