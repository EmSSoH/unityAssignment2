using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileShooter : MonoBehaviour
{


    GameObject prefab;

    void Start()
    {
        prefab = Resources.Load("Bullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(prefab) as GameObject;
            bullet.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
            Destroy(bullet, 5);
        }
    }
}
