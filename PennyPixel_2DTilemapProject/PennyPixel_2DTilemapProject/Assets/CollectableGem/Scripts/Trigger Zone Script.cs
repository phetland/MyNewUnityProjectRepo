using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZoneScript : MonoBehaviour
{
    public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            textbox.text = "You win!";
        }
    }
}
