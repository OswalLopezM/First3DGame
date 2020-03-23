using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidbody; 
    public float forwarForce = 2000f;
    public float sidewaysForce = 500f;

    // Cuando se cambien fisicas hacerlo en el FixedUpdate 
    void FixedUpdate()
    {
        rigidbody.AddForce(0 , 0, forwarForce * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if( Input.GetKey("a") )
        {
            rigidbody.AddForce( -sidewaysForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
        }
        if( rigidbody.position.y < -1f  )
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        
            
    }
}
