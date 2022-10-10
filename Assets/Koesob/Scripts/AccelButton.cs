using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelButton : MonoBehaviour
{
    public GameObject button;

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();

        if (player != null)
        {
            OnButton();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<Player>();

        if (player != null)
        {
            OffButton();
        }
    }

    private void OnButton()
    {

    }

    private void OffButton()
    {

    }

    IEnumerator OnButtonCoroutine()
    {
        yield return null;
    }
}
