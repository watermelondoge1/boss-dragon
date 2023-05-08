using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{  
    void OnTriggerEnter2D(Collider2D collision) 
    {
        if( collision.tag == "TopScreenedge") 
        {
         obj.velocity = new Vector2 (0, -speed); 
        } 
        if ( collision.tag == "BottomScreenedge")
        {obj.velocity = new Vector2 (0, speed);}    

        

    }
        public float speed = 3;

     private Rigidbody2D obj; 
     
     void Start () {

         obj = GetComponent<Rigidbody2D> ();
             }
         
         void Update () {}
 
}