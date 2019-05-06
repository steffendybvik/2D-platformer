using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBehavior : AbstractBehavior {
    private float jumpSpeed = 10f;
    public LayerMask collisionLayer;
    public Vector3 size;
    public Vector2 bottomPosition = Vector2.zero;
    public Vector2 rightPosition = Vector2.zero;
    public Vector2 leftPosition = Vector2.zero;
    public float collisionRadius = .7f;
    public bool standing;

    protected override void UpdateExtend () {
        OnGround ();
        if (Input.GetKeyDown (KeyCode.Space) && standing) {
            Jump ();
        }
    }

    private void Jump () {
        animator.SetBool ("Jumping", true);
        var vel = rigidbody2D.velocity;
        rigidbody2D.velocity = new Vector2 (vel.x, jumpSpeed);
    }

    private void OnDrawGizmos () {
        var positions = new Vector2[] { rightPosition, bottomPosition, leftPosition };
        foreach (var position in positions) {
            var pos = position;
            pos.x += transform.position.x;
            pos.y += transform.position.y;

            Gizmos.DrawWireSphere (pos, collisionRadius);
        }
    }

    private void OnGround () {
        var pos = bottomPosition;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        standing = Physics2D.OverlapCircle (pos, collisionRadius, collisionLayer);
    }
}