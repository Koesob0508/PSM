using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEntrance : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();

        if(player != null)
        {
            Ship.Instane.EnterPlayer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<Player>();

        if (player != null)
        {
            Ship.Instane.ExitPlayer();
        }
    }
}
