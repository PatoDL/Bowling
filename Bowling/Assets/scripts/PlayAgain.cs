using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
    GameObject gm;
    GameObject canvas;
    GameObject pinGen;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
        canvas = GameObject.Find("Canvas");
        pinGen = GameObject.Find("PinGenerator");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAgain()
    {
        gm.GetComponent<GameManager>().setGO(false);
        gm.GetComponent<GameManager>().setRes(false);
        gm.GetComponent<BallShotSwitcher>().shot = 1;
        canvas.transform.Find("Result").GetComponent<DrawResult>().result.text = "";
        pinGen.GetComponent<PinGenerator>().pinMaker();
        this.gameObject.SetActive(false);
    }
}
