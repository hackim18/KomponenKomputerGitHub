using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBackgroundScript : MonoBehaviour
{
    private static GridBackgroundScript playerInstance;
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
