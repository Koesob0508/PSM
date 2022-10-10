using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject fuelObject;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

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
        Instantiate(fuelObject).transform.position = gameObject.transform.position;

        Destroy(this.gameObject);
    }
}
