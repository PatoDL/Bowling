using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinChecker : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
