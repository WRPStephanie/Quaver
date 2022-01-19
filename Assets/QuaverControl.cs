using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaverControl : MonoBehaviour
{
    public float volume;

    public float JumpForce = 500f;
    public float MaxSpeed = 5;

    Rigidbody2D rg;

    float tempTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        volume = MicInput.volume;
        if (volume > 0.1)
        {
            MoveForward();
            if (rg.velocity.x > MaxSpeed)
            {
                rg.velocity = new Vector2(MaxSpeed, rg.velocity.y);
            }
        }
        if (volume > 0.5)
        {
            if (Time.time - tempTime > 2)
            {
                Jump();
                tempTime = Time.time;
            }
            
        }
    }

    void Jump()
    {
        rg.AddForce(Vector2.up * JumpForce * volume);
    }

    void MoveForward()
    {
        rg.AddForce(Vector2.right * 10);
    }
}
