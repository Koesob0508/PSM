using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] bool isAlive = true;


    Rigidbody Rigidbody;
    Vector3 movement;
    [SerializeField] float moveSpeed = 100f;

    [SerializeField] const float maxOxygen = 100f;
    [SerializeField] float curOxygen = 100f;
    [SerializeField] float spendOxygen = 10f;



    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        curOxygen = maxOxygen;
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Breath();
    }

    void Move(float h, float v)
    {
        if (!isAlive) return;

        movement.Set(0, v, h);
        movement = movement.normalized * moveSpeed * Time.deltaTime;

        Rigidbody.velocity = movement;
    }

    void Breath()
    {
        if (!isAlive) return;

        if (curOxygen > 0)
        {
            curOxygen -= spendOxygen * Time.deltaTime;
        }
        else
        {
            Die();
        }
    }

    void Die()
    {
        if (!isAlive) return;

        isAlive = false;
    }
}
