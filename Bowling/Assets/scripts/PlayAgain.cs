using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAgain()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().setGO(false);
        GameObject.Find("GameManager").GetComponent<GameManager>().setRes(false);
        GameObject.Find("GameManager").GetComponent<BallShotSwitcher>().shot = 1;
        GameObject.Find("Canvas").transform.Find("Result").GetComponent<DrawResult>().result.text = "";
        GameObject.Find("PinGenerator").GetComponent<hacerPinos>().pinMaker();
        this.gameObject.SetActive(false);
    }
}
