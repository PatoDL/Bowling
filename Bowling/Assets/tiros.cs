using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiros : MonoBehaviour
{
    const int cantTiros = 3;
    int tiroActual = 0;
    public GameObject pinos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiroActual==cantTiros)
        {
            Debug.Log("El juego ha finalizado, presione enter para volver a jugar");
            //if()
        }
    }
}
