using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var collision = other.GetComponent<ICollisionable>();
        if (collision != null)
        {
            collision.Collision();
            Destroy();
        }
    }

    private void Destroy()
    {
        var fuelObject = Resources.Load<GameObject>("Prefabs/Fuel");
        if (fuelObject != null)
            Instantiate(fuelObject).transform.position = gameObject.transform.position;

        Destroy(this.gameObject);
    }
}
