using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject frontWall;

    private static Ship instance;
    private Rigidbody shipRigidbody;
    public float accelAmount;
    public static Ship Instane
    {
        get
        {
            if (instance == null)
            {
                return null;
            }
            else
            {
                return instance;
            }
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        shipRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        StartCoroutine(TestBoost());
    }

    public void EnterPlayer()
    {
        frontWall.SetActive(false);
    }

    public void ExitPlayer()
    {
        frontWall.SetActive(true);
    }

    public void Accel()
    {
        Vector3 velocity = new Vector3(0, 0, accelAmount);
        shipRigidbody.AddForce(velocity, ForceMode.Acceleration);
    }

    private IEnumerator TestBoost()
    {
        yield return new WaitForSeconds(3f);

        Accel();
    }
}
