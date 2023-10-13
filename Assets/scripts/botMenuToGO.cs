using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botMenuGoTo : MonoBehaviour
{

    //save var
    public int mode;
    public string leftOrRight = "or";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {

            SceneManager.LoadScene("menu");
        }
        //look for input for diff and side
        if (Input.GetKey(KeyCode.Alpha1))
        {
            mode = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            mode = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            mode = 3;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            mode = 4;
        }

        if (Input.GetKey(KeyCode.L))
        {
            leftOrRight = "left";
        }
        else if (Input.GetKey(KeyCode.R))
        {
            leftOrRight = "right";
        }

        
        if (Input.GetKey(KeyCode.Return))
        {

            //easy
            if (mode == 1)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPong");

                } else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPong");

                }
                else
                {
                    SceneManager.LoadScene("botPong");

                }
            }

            //medium
            else if (mode == 2)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPong");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPong");

                }
                else
                {
                    SceneManager.LoadScene("botPong");

                }
            }

            //hard
            else if (mode == 3)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPong");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPong");

                }
                else
                {
                    SceneManager.LoadScene("botPong");

                }
            }

            //imposable
            else if (mode == 4)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPong");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPong");

                }
                else
                {
                    SceneManager.LoadScene("botPong");

                }
            }
            
            //if no diff is chosen
            else
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPong");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPong");

                }
                else
                {
                    SceneManager.LoadScene("botPong");

                }
            }
        }


    }
}

