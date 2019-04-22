using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawResult : MonoBehaviour
{
    public Text result;
    GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.GetComponent<GameManager>().getGO())
        {
            if(gm.GetComponent<GameManager>().getRes())
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
