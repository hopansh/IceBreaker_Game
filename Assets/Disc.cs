using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disc : MonoBehaviour
{
    [SerializeField] private float screenWidth = 21.33f;

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            
            float mouseVal = (Input.GetTouch(0).position.x / Screen.width * screenWidth);
            Vector2 paddlePos = new Vector2(mouseVal,2.3f);
            paddlePos.x = Mathf.Clamp(mouseVal, 1.27f, 19.88f);
            transform.position = paddlePos;
            }
           
        }
    
}