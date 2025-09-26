using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (transform.position.z < -14)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -14);
        }

        if (transform.position.z > 39)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 39);
        }

    }
}
