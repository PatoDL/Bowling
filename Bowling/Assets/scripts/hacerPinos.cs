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
    GameObject[] p = new GameObject[cantPins];

    bool[] dontRepeat = new bool[cantPins];
    // Start is called before the first frame update
    void Start()
    {
        if (objPin)
        {
            for (int i = 0; i < cantPins; i++)
            {
                pins[i] = objPin;
                p[i] = Instantiate(pins[i]);
                p[i].transform.position = posiciones[i];
            }
        }

        Debug.Log("Bienvenido al Bowling! Utilice las flechas izquierda y derecha para elegir la posicion inicial de la bola.");
        Debug.Log("utilice las flechas arriba y abajo para aumentar o disminuir la fuerza con la que saldra la bola.");
        Debug.Log("una vez que todo esté listo, presione espacio para lanzar la bola.");
        Debug.Log("tiene 3 intentos para derribar todos los pinos, mucha suerte!");

        bool[] dontRepeat = new bool[cantPins];
        for(int i=0;i<cantPins;i++)
        {
            dontRepeat[i] = false;
        }
    }

    // Update is called once per frame
   
    void Update()
    {
        for(int i=0;i<cantPins;i++)
        {
            if (!(p[i].activeSelf) && !dontRepeat[i])
            {
                activePins--;
                dontRepeat[i] = true;
            }
        }

        if(activePins==0)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().setGO(true);
            GameObject.Find("GameManager").GetComponent<GameManager>().setRes(true);
        }
    }
}
