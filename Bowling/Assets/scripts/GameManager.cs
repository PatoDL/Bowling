using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool GameOver = false;
    bool win = false;
    GameObject canvas;
    private static GameManager instance;

    public static GameManager Get()
    {
        return instance;
    }

    void Start()
    {
        canvas = GameObject.Find("Canvas");
    }

    void Update()
    {
        if (getGO())
        {
            canvas.transform.Find("PlayAgain").gameObject.SetActive(true);
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
