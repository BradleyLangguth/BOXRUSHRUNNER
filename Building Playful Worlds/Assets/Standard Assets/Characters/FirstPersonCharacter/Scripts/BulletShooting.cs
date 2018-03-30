using UnityEngine;
using UnityEngine.Networking;

public class BulletShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform bulletSpawn;

        void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Pressed left click.");
            Fire();
        }

        //if (Input.GetMouseButton(1))
            //Debug.Log("Pressed right click.");

        //if (Input.GetMouseButton(2))
            //Debug.Log("Pressed middle click.");

        


    }


    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        // Destroy the bullet after 9 seconds
        Destroy(bullet, 5.0f);
    }

}