using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;
    public Poolmanager pool;
    public Player player;
    public float gameTime;
    public float maxgameTime = 2 * 10f;

    void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        gameTime += Time.deltaTime;

        if(gameTime > maxgameTime)
        {
             gameTime = maxgameTime;
        }
    }
}
