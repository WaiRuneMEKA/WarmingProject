using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public Test1 test1;
    //int speed;
    //int jumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        test1 = new Test1();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            test1.InitializeNode(10, 2);

            Debug.Log(test1.Speed);
        }
    }
}
