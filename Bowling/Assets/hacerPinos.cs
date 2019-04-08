using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hacerPinos : MonoBehaviour
{
    public struct pino
    {
        public Transform pinObj;
        public bool existencia;
    }


    public int ronda = 1;
    public Transform objPino;
    const int cantPinos = 10;
    public pino[] pinos = new pino[cantPinos];

    public Vector3[] posiciones = new Vector3[cantPinos];

    // Start is called before the first frame update
    void Start()
    {
        if (objPino)
        {
            for (int i = 0; i < cantPinos; i++)
            {
                pinos[i].pinObj = objPino;
                Transform p = Instantiate(pinos[i].pinObj);
                p.transform.position = posiciones[i];
                pinos[i].existencia = true;
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
       
    }
}
