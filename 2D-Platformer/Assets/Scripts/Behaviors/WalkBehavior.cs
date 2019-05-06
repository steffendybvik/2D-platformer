using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkBehavior : AbstractBehavior {

    protected override void UpdateExtend () {
        if (Input.GetKey (KeyCode.D)) {
            if (speed < 0f) {
                speed += deacceleration;
            } else if (speed < maxSpeed) {
                speed += acceleration;
            }

            if (speed > maxSpeed) {
                speed = maxSpeed;
            }
        } else if (Input.GetKey (KeyCode.A)) {
            if (speed > 0f) {
                speed -= deacceleration;
            } else if (speed > -maxSpeed) {
                speed -= acceleration;
            }

            if (speed < -maxSpeed) {
                speed = -maxSpeed;
            }
        } else if (Mathf.Abs (speed) > 0.001f) {
            var ratio = 1f / (1 + (Time.deltaTime * friction));
            speed *= ratio;
        } else {
            speed = 0f;
        }
        rigidbody2D.velocity = new Vector2 (speed, rigidbody2D.velocity.y);
    }
}