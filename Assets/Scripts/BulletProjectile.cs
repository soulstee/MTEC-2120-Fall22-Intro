using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public GameObject Bullet;

public class BulletProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Z"))
        {
            GameObject BulletProjectile = Instantiate(BulletProjectile, transform.position, transform.rotation);
            BulletProjectile.GetComponent<RigidBody>().AddRelativeForce(x, y, z);
        }
    }
}
