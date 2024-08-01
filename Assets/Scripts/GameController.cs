﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platform;
    float pos = 0;
    
    public GameObject gameOverCanvas;
    
    void Start()
    {
        for (int i = 0; i < 1000; i++){
            SpawnPlatforms();
        }
    }

    void SpawnPlatforms(){
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);

        pos += 2.5f;
    }

    public void GameOver(){
        gameOverCanvas.SetActive(true);
    }
}
