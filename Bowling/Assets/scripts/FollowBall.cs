using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public GameObject ball;
    public Vector3 origPos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.x<18 && ball.transform.position.x > -20)
        {
            transform.position = new Vector3(ball.transform.position.x+10.0f, origPos.y, origPos.z);
        }
        else
        {
            transform.position = origPos;
        }
    }
}
