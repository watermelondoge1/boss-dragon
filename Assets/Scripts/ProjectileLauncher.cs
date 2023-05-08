using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public float fireRate = 0.25f; // The delay between shots in seconds
    private bool canFire = true; // A flag to control the firing rate

    IEnumerator LaunchProjectile()
    {
        canFire = false; // Set the flag to false so that the coroutine cannot be started again while the projectile is still being fired
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        Rigidbody2D projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
        projectileRigidbody.AddForce(transform.right * projectileSpeed, ForceMode2D.Impulse);
        yield return new WaitForSeconds(fireRate); // Wait for the specified delay before setting the flag to true again
        canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            StartCoroutine(LaunchProjectile());
        }
    }
}
