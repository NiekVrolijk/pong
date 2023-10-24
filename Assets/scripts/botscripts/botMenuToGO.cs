using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class botMenuGoTo : MonoBehaviour
{

    //save var
    public int mode;
    public string leftOrRight = "or";
    public int lOrR;

    //text
    public GameObject difGameObject;
    public GameObject lOrRGameObject;
    public GameObject menuGameObject;
    public TMPro.TMP_Text dif;
    public TMPro.TMP_Text pLOrR;
    public TMPro.TMP_Text menu;

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
            dif.text = "easy: press 1 ; X \r\nmedium: press 2 ; O \r\nhard: press 3 ; O \r\nif you dont wanne win: press 4 ; O ";
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            mode = 2;
            dif.text = "easy: press 1 ; O \r\nmedium: press 2 ; X \r\nhard: press 3 ; O \r\nif you dont wanne win: press 4 ; O ";
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            mode = 3;
            dif.text = "easy: press 1 ; O \r\nmedium: press 2 ; O \r\nhard: press 3 ; X \r\nif you dont wanne win: press 4 ; O ";
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            mode = 4;
            dif.text = "easy: press 1 ; O \r\nmedium: press 2 ; O \r\nhard: press 3 ; O \r\nif you dont wanne win: press 4 ; X ";
        }

        if (Input.GetKey(KeyCode.L))
        {
            leftOrRight = "left";
            pLOrR.text = "if you want to play left: press L ; X\r\nif you wan to play right: press R ; O";
        }
        else if (Input.GetKey(KeyCode.R))
        {
            leftOrRight = "right";
            pLOrR.text = "if you want to play left: press L ; O\r\nif you wan to play right: press R ; X";
        }

        
        if (Input.GetKey(KeyCode.Return))
        {

            //easy
            if (mode == 1)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPongEL");

                } else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPongER");

                }
                else
                {
                    var lOrR = Random.Range(0, 2);
                    if (lOrR == 0)
                    {
                        SceneManager.LoadScene("botPongEL");
                    }
                    else
                    {
                        SceneManager.LoadScene("botPongER");
                    }
                }
            }

            //medium
            else if (mode == 2)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPongML");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPongMR");

                }
                else
                {
                    var lOrR = Random.Range(0, 2);
                    if (lOrR == 0)
                    {
                        SceneManager.LoadScene("botPongML");
                    }
                    else
                    {
                        SceneManager.LoadScene("botPongMR");
                    }
                }
            }

            //hard
            else if (mode == 3)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPongHL");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPongHR");

                }
                else
                {
                    var lOrR = Random.Range(0, 2);
                    if (lOrR == 0)
                    {
                        SceneManager.LoadScene("botPongHL");
                    }
                    else
                    {
                        SceneManager.LoadScene("botPongHR");
                    }
                }
            }

            //imposable
            else if (mode == 4)
            {
                if (leftOrRight == "left")
                {
                    SceneManager.LoadScene("botPongIL");

                }
                else if (leftOrRight == "right")
                {
                    SceneManager.LoadScene("botPongIR");

                }
                else
                {
                    var lOrR = Random.Range(0, 2);
                    if (lOrR == 0)
                    {
                        SceneManager.LoadScene("botPongIL");
                    }
                    else
                    {
                        SceneManager.LoadScene("botPongIR");
                    }
                }
            }
            
            //if no diff is chosen
            else
            {
                if (leftOrRight == "left")
                {
                    var mode = Random.Range(0, 3);
                    if (mode == 0)
                    {
                        SceneManager.LoadScene("botPongEL");
                    }
                    else if (mode == 1)
                    {
                        SceneManager.LoadScene("botPongML");
                    }
                    else if (mode == 2)
                    {
                        SceneManager.LoadScene("botPongHL");
                    }

                }
                else if (leftOrRight == "right")
                {
                    var mode = Random.Range(0, 3);
                    if (mode == 0)
                    {
                        SceneManager.LoadScene("botPongER");
                    }
                    else if (mode == 1)
                    {
                        SceneManager.LoadScene("botPongMR");
                    }
                    else if (mode == 2)
                    {
                        SceneManager.LoadScene("botPongHR");
                    }

                }
                else
                {
                    var mode = Random.Range(0, 6);
                    if (mode == 0)
                    {
                        SceneManager.LoadScene("botPongEL");
                    }
                    else if (mode == 1)
                    {
                        SceneManager.LoadScene("botPongER");
                    }
                    else if (mode == 2)
                    {
                        SceneManager.LoadScene("botPongML");
                    }
                    else if (mode == 3)
                    {
                        SceneManager.LoadScene("botPongMR");
                    }
                    else if (mode == 4)
                    {
                        SceneManager.LoadScene("botPongHL");
                    }
                    else if (mode == 5)
                    {
                        SceneManager.LoadScene("botPongHR");
                    }
                }
            }
        }


    }
}

