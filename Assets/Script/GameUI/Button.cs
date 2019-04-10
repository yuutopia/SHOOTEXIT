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
            transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
        }
        if (leftmove == true)
        {
            transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
        }
    }
    public void rightButtonUP(){
        rightmove = false;
    }
    public void rightButtonDOWN(){
        rightmove = true;
    }

    public void leftButtonUP(){
        leftmove = false;
    }
    public void leftButtonDOWN(){
        leftmove = true;
    }
}
