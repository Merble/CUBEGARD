using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 800f;
    public float sideWaysForce = 500f;

    // I changed the name from Update to FixedUpdate
    // because I mess with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  //Add a forward force.

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
