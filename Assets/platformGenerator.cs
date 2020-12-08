using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject standardplatform;
    public GameObject bouncyplatform;
    public GameObject coin;

    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
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
            }
        }
    }
}