using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1
{
    public float Speed { get; set; }
    public float JumpForce { get; set; }
    public void InitializeNode(float speed, float jumpForce)
    {
        Speed = speed;
        JumpForce = jumpForce;
    }
}
