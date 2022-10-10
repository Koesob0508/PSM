using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelButton : MonoBehaviour
{
    public GameObject button;
    public float onY;
    public float offY;

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
        StartCoroutine(OnButtonCoroutine());

        Ship.Instane.Accel();
    }

    private void OffButton()
    {
        StartCoroutine(OffButtonCoroutine());
    }

    IEnumerator OnButtonCoroutine()
    {
        var buttonPosition = button.transform.localPosition;
        while (buttonPosition.y > offY)
        {
            buttonPosition.y -= 0.001f;
            button.transform.localPosition = buttonPosition;

            yield return new WaitForSeconds(0.01f);
        }
    }

    IEnumerator OffButtonCoroutine()
    {
        var buttonPosition = button.transform.localPosition;
        while (buttonPosition.y < onY)
        {
            buttonPosition.y += 0.001f;
            button.transform.localPosition = buttonPosition;

            yield return new WaitForSeconds(0.01f);
        }
    }
}
