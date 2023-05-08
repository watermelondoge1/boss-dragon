using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncherBullet : MonoBehaviour
{
    public GameObject projectilePrefab;


    void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.tag == "ScreenEdge" || collision.tag == "Enemy")
    {
        Destroy(gameObject);
    }
}

}