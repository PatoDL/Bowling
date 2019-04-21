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
        GetComponent<GameManager>().setGO(false);
        GetComponent<GameManager>().setRes(false);
        GetComponent<BallShotSwitcher>().shot = 1;
    }
}
