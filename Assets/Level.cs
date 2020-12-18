using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    private SceneLoad loadScene;
    public void  CountBBlock()
    {
        breakableBlocks++;
        
    }

    private void Start()
    {
        loadScene = FindObjectOfType<SceneLoad>();
    }

    public void BlockDestroy()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            loadScene.LoadWin();
        }
    }
}
