using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pong : MonoBehaviour
{

    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xdirection = 1f;
    public float ydirection = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(xPosition, yPosition, 0f);

        if (xdirection == 1f)
        {
            xPosition = xPosition + 7f * Time.deltaTime;
        }
        if (xdirection == 0f)
        {
            xPosition = xPosition + -7f * Time.deltaTime;
        }

        if (xPosition > 9.8f)
        {
            xdirection = 0f;
        }
        if (xPosition < -9.8f)
        {
            xdirection = 1f;
        }


        if (ydirection == 1f)
        {
            yPosition = yPosition + 7f * Time.deltaTime;
        }
        if (ydirection == 0f)
        {
            yPosition = yPosition + -7f * Time.deltaTime;
        }

        if (yPosition > 4.8f)
        {
            ydirection = 0f;
        }
        if (yPosition < -4.8f)
        {
            ydirection = 1f;
        }
    }
}
