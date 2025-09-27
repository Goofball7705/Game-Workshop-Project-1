using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 10.0f;
    public GameObject Laser;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        //checks for up down left and right input

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up *  verticalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Laser, transform.position, Laser.transform.rotation);
        }


        //keeps the player in bounds
        if (transform.position.z < -14)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -14);
        }

        if (transform.position.z > 39)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 39);
        }

        if (transform.position.y > 27)
        {
            transform.position = new Vector3(transform.position.x, 27, transform.position.z);
        }

        if (transform.position.y < 3)
        {
            transform.position = new Vector3(transform.position.x, 3, transform.position.z);
        }
    }
}
