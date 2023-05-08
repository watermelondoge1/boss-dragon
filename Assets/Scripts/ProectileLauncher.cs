using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public bool firing = false;

public float projectileSpeed = 10f;

    void OnTriggerEnter2D(Collider2D collision)
{
  if ( collision.tag == "ScreenEdge" || collision.tag == "Enemy")
    {
        Destroy(GameObject.FindWithTag("Projectile"));
    }
}


    void LaunchProjectile()
{
    if(firing == true) 
    {
    GameObject projectile  = Instantiate(projectilePrefab  , transform.position, Quaternion.identity);
    Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
    projectileRigidbody.AddForce(transform.right * projectileSpeed, ForceMode2D.Impulse);
    projectileRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY; 
    firing = false;
    }
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        
{
    if (Input.GetKeyDown(KeyCode.Space))
    {  //Coroutine WaitForSeconds(3);
        firing = true;
    }
}

    }
}
