using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flight : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody2D rb;
    Vector2 m_YAxis;
    public Rigidbody2D m_Rigidbody2D;
    //private float thrust = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float yAxis = Input.GetAxis("Vertical");
        //if (Input.GetButtonDown ("Vertical"))
        //{
            //rb.AddForce(transform.up * thrust);
           //m_Rigidbody2D.velocity = m_YAxis;
        //}
     ThrustForward(yAxis);
   }

    private void ClampVelocity()
    {

   }
    private void ThrustForward (float amount)
    { 
        if(Mathf.Abs (amount) > Mathf.Epsilon) 
        {
            rb.velocity = new Vector2 (rb.velocity.x, amount * speed);
        }
        else 
        {
            rb.velocity =  Vector2.zero;
        }
        
       //Vector2 force = transform.up * amount;
        //rb.AddForce(force);
   }
}
