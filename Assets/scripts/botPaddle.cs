//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;
//using UnityEngine.UIElements;
//public class botPaddle : MonoBehaviour
//{
//    //var
//    public float speed = 5f;
//    public string leftOrRight;
//    public float maxValue = 3.75f;
//    public GameObject ball;

//    //movement (and make sure paddle doesn't leave our world
//    void paddleControl(KeyCode up,KeyCode down)
//    {
//        if (Input.GetKey(up) && transform.position.y < maxValue)
//        {
            
//            transform.Translate(Vector3.up * speed * Time.deltaTime);
//        }
//        else if (Input.GetKey(down) && transform.position.y > -maxValue)
//        {
            
//            transform.Translate(Vector3.down * speed * Time.deltaTime);
//        }
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //diside if it should be left paddle or right paddle
//        if(leftOrRight == "left")
//        {
//         paddleControl(KeyCode.W,KeyCode.S); 
//        } else if(leftOrRight == "right")
//        {
//            paddleControl(KeyCode.UpArrow,KeyCode.DownArrow);
//        }

//        transform.position = new Vector3(transform.position.x, ball.transform.position.y, 0f);
//    }
//}
