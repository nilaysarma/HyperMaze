using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed" Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {
        if(Input.GetKey("up"))
        {
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
