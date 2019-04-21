using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawResult : MonoBehaviour
{
    public Text result;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("GameManager").GetComponent<GameManager>().getGO())
        {
            if(GameObject.Find("GameManager").GetComponent<GameManager>().getRes())
            {
                result.text = "Felicidades!, has ganado.";
            }
            else
            {
                result.text = "Oh que lastima, ha perdido...";
            }
        }
    }
}
