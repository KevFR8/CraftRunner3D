using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwadForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate ()
    {

        // Direction du joueur 
        rb.AddForce(0, 0, forwadForce * Time.deltaTime);

        // Si le joueur presse "d" il va à droite
        if (Input.GetKey("d") ) 
        {
            rb.AddForce(sidewayForce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         // Si le joueur presse "q" il va à gauche
        if (Input.GetKey("a") ) 
        {
            rb.AddForce(-sidewayForce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
