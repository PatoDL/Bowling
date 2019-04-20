using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinChecker : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name != "Ball")
        {
            other.gameObject.SetActive(false);
        }
    }
}
