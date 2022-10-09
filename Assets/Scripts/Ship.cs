using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public GameObject frontWall;

    private static Ship instance;
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
    }

    public void EnterPlayer()
    {
        frontWall.SetActive(false);
    }

    public void ExitPlayer()
    {
        frontWall.SetActive(true);
    }
}
