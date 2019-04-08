using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xd : MonoBehaviour
{
    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.name=="pino(Clone)")
        {
            Destroy(col.gameObject);
        }
    }
}
