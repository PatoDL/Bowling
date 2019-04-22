using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool GameOver = false;
    bool win = false;

    private static GameManager instance;

    public static GameManager Get()
    {
        return instance;
    }

    void Update()
    {
        if (getGO())
        {
            GameObject.Find("Canvas").transform.Find("PlayAgain").gameObject.SetActive(true);
        }
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void setGO(bool go)
    {
        GameOver = go;
    }

    public void setRes(bool res)
    {
        win = res;
    }

    public bool getRes()
    {
        return win;
    }

    public bool getGO()
    {
        return GameOver;
    }
}
