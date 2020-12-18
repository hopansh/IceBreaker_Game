using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private static int currLevel = 4;
    public void LoadNextScene()
    {
        int currSceneInd = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((currSceneInd + 1)%10);
        
    }

    public void QuitApp()
    {
        Application.Quit();
    }
    public void LoadHome()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }
  
    public void LoadLevels()
    {
        SceneManager.LoadScene(currLevel);
    }

    public void LoadWin()
    {
        if (currLevel < 6)
        {
            currLevel = currLevel + 1;
            SceneManager.LoadScene(3);
        }
        else if (currLevel >= 6)
        {
            currLevel = 4;
            SceneManager.LoadScene(2);
        }
        
    }
}