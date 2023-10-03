using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float xPosition = 0f;
    public float yPosition = 0f;
    public float xSpeed = 3f;
    public float ySpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
       

            xPosition = xPosition + xSpeed * Time.deltaTime;
            yPosition = yPosition + ySpeed * Time.deltaTime;
       
            transform.position = new Vector3(xPosition, yPosition, 0f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ow");
        if (collision.gameObject.CompareTag("horizontal")) 
        {
            Debug.Log("help or help me");
            ySpeed = ySpeed * -1f;
        }else if (collision.gameObject.CompareTag("vertical"))
        {
            Debug.Log("nooooooooo");
            xSpeed = xSpeed * -1f;
        }
    }
}
