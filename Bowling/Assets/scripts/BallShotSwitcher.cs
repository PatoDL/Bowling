using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShotSwitcher : MonoBehaviour
{
    bool gameOver = false;
    const int totalShots = 3;
    int shot = 1;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < -3)
        {
            shot++;
        }
        if (shot>3)
        {
            gameOver = true;
        }
    }
}
