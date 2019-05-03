using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : AbstractBehavior
{
    public float speed;
    protected override void UpdateExtend()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (gsp < 0f)
            {
                gsp += dec;
            }
            else if (gsp < top)
            {
                gsp += acc;
            }

            if (gsp > top)
            {
                gsp = top;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (gsp > 0f)
            {
                gsp -= dec;
            }
            else if (gsp > -top)
            {
                gsp -= acc;
            }

            if (gsp < -top)
            {
                gsp = -top;
            }
        }
        else if (Mathf.Abs(gsp) > 0.001f)
        {
            var ratio = 1f / (1 + (Time.deltaTime * frc));
            gsp *= ratio;
        }
        else
        {
            gsp = 0f;
        }
        rigidbody2D.velocity = new Vector2(gsp, rigidbody2D.velocity.y);
        speed = gsp;
    }
}