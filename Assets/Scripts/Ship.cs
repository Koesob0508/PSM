using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    public GameObject frontWall;

    private static Ship instance;
    private Rigidbody shipRigidbody;
    public float accelAmount;
    public Slider resourceSlider;
    public float totalResource;
    public float currentResource;
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
        currentResource = totalResource;
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

        UseResource(30f);
    }

    private IEnumerator TestBoost()
    {
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(3f);

            Accel();
        }
    }

    private bool UseResource(float _amount)
    {
        if((currentResource - _amount) > 0)
        {
            currentResource = currentResource - _amount;

            resourceSlider.value = currentResource / totalResource;

            return true;
        }
        else
        {
            Debug.Log("연료가 부족합니다.");
            return false;
        }
    }
}
