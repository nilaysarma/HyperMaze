using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }

    // public float speed;
    // [SerializeField] private Joystick joystick;

    // // Update is called once per frame
    // void FixedUpdate()
    // {
    //     float xMovement = joystick.Horizontal;
    //     float zMovement = joystick.Vertical;

    //     transform.position += new Vector3(xMovement, 0f, zMovement) * speed * Time.deltaTime;
    // }
}
