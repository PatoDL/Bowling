using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShotSwitcher : MonoBehaviour
{
    const int totalShots = 3;
    public int shot = 1;
    public GameObject ball;
    Vector3 ballOrigPos;

    // Start is called before the first frame update
    void Start()
    {
        ballOrigPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < -3)
        {
            shot++;
            ball.GetComponent<BallMovement>().force = 0;
            ball.GetComponent<BallMovement>().bolaEnJuego = false;
            ball.GetComponent<Rigidbody>().isKinematic = true;
            ball.transform.position = ballOrigPos;
            ball.GetComponent<Rigidbody>().isKinematic = false;
        }
        if (shot>totalShots)
        {
            shot = totalShots;
            GetComponent<GameManager>().setGO(true);
            
        }
    }
}
