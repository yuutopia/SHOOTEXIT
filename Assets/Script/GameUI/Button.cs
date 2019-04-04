using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool rightmove;
    bool leftmove;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rightmove == true)
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        }
        if (leftmove == true)
        {
            transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
        }
    }
    public void rightButtonUP(){
        rightmove = true;
    }
    public void rightButtonDOWN(){
        rightmove = false;
    }

    public void leftButtonUP(){
        leftmove = true;
    }
    public void leftButtonDOWN(){
        leftmove = false;
    }
}
