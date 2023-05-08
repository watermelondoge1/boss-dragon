using UnityEngine;
using System.Collections;
 
public class shooter : MonoBehaviour
{
    public Rigidbody2D projectile;
    public float speed = 20;
    void Start()
    {

    }
 
    // Update is called once per frame
    void Update ()
    { 
        if(gameObject.name == "New Sprite (1)(Clone)")
        {
            //Rigidbody2d.constraints
            Destroy(gameObject, 5 );              
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D instantiatedProjectile = Instantiate(projectile,transform.position,transform.rotation)as Rigidbody2D;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(5, 0,speed));
        }

    }
}