using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;
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
    
    GameObject projectile  = Instantiate(projectilePrefab  , transform.position, Quaternion.identity);
    Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
    projectileRigidbody.AddForce(transform.right * projectileSpeed, ForceMode2D.Impulse);
    projectileRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
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
    {
        LaunchProjectile();
    }
}

    }
}
