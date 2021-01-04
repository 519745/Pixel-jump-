using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    public GameObject standardplatform;
    public GameObject bouncyplatform;
    public GameObject coin;

    public int CoinSpawn;
    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY;
    public float maxY;
    void Start()
    {

        Vector3 spawnPosition = new Vector3();


        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            
            if (i == 20)
            {
                Instantiate(bouncyplatform, spawnPosition, Quaternion.identity);
            }
            else
            {
                Instantiate(standardplatform, spawnPosition, Quaternion.identity);

                if (i == numberOfPlatforms)
                {
                    //finalCoin = Instantiate(coin, new Vector2(), Quaternion.identity);
                    //finalCoin.name = "fn";
                    //finalCoin = GameObject.Find("fn");
                }
            }
        }
    }
}