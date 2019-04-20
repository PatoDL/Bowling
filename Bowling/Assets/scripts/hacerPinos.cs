using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacerPinos : MonoBehaviour
{
    public GameObject objPin;
    const int cantPins = 10;
    public GameObject[] pins = new GameObject[cantPins];
    public Vector3[] posiciones = new Vector3[cantPins];
    public int activePins = cantPins;

    // Start is called before the first frame update
    void Start()
    {
        if (objPin)
        {
            for (int i = 0; i < cantPins; i++)
            {
                pins[i] = objPin;
                GameObject p = Instantiate(pins[i]);
                p.transform.position = posiciones[i];
            }
        }

        Debug.Log("Bienvenido al Bowling! Utilice las flechas izquierda y derecha para elegir la posicion inicial de la bola.");
        Debug.Log("utilice las flechas arriba y abajo para aumentar o disminuir la fuerza con la que saldra la bola.");
        Debug.Log("una vez que todo esté listo, presione espacio para lanzar la bola.");
        Debug.Log("tiene 3 intentos para derribar todos los pinos, mucha suerte!");
    }

    // Update is called once per frame
    void Update()
    {
       for(int i=0;i<cantPins;i++)
        {
            if (!pins[i].activeSelf)
            {
                activePins--;
                Debug.Log("xd");
            }
        }
    }
}
