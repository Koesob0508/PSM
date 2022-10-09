using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                return null;
            }

            return instance;
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


    void Start()
    {

    }


    void Update()
    {

    }

    public void WinGame()
    {
        Debug.Log("Win Game");
    }

    public void DefeatGame()
    {
        Debug.Log("Defeat Game");
    }
}
