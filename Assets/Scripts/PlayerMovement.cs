using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;
    // public Joystick Joystick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rb.AddForce( 0, 0 , 2000 * Time.deltaTime );
    }

    void FixedUpdate()
    {
        var Joystick = FindObjectOfType<Joystick>();
        if (Input.GetKey("d") || Joystick.Horizontal > .2f)
        {
            Rb.AddForce(500 * Time.deltaTime, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey("a") || Joystick.Horizontal < -.2f)
        {
            Rb.AddForce(-500 * Time.deltaTime, 0, 0, ForceMode.Force);
        }

        if (Input.GetKey("w") || Joystick.Vertical > .2f)
        {
            Rb.AddForce(0, 0, 500 * Time.deltaTime, ForceMode.Force);
        }
        if (Input.GetKey("s") || Joystick.Vertical < -.2f)
        {
            Rb.AddForce(0, 0, -500 * Time.deltaTime, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Rb.AddForce(0, 1000 * Time.deltaTime, 0);
        }

        if (Rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerV1>().EndGame();
        }
    }

   
}