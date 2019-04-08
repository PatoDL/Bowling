using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="bola")
        {
            other.GetComponent<hacerPinos>().ronda++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
