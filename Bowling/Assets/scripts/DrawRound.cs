using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawRound : MonoBehaviour
{
    public Text round;
    GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        round.text = "Round: " + gm.GetComponent<BallShotSwitcher>().shot;
    }
}
