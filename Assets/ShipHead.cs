using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHead : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var goal = other.GetComponent<Moon>();

        if (goal != null)
        {
            GameManager.Instance.WinGame();
        }
    }
}
