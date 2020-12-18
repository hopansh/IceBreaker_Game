using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Disc disc;
    [SerializeField] private float xPush = 2f , yPush=15f;
    private bool launch = false;
    private Vector2 paddleToBallVector;
    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - disc.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!launch)
        {
            StickBall();
            LaunchOnMouseClick();
        }
    }

    private void StickBall()
    {
        Vector2 discPos = new Vector2(disc.transform.position.x, disc.transform.position.y);
        transform.position = discPos + paddleToBallVector;
    }

    void LaunchOnMouseClick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            launch = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
        }
        else if (Input.touchCount > 0)
        {
            launch = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
        }
    }
}
