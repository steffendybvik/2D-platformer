using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractBehavior : MonoBehaviour {

    protected GameObject character;
    protected Rigidbody2D rigidbody2D;
    protected Animator animator;

    protected float speed = 0;
    protected float maxSpeed = 10f;
    protected float friction = 5f;
    protected float acceleration = .2f;
    protected float deacceleration = .5f;

    public void Awake () {
        character = this.gameObject;
        rigidbody2D = character.GetComponent<Rigidbody2D> ();
        animator = gameObject.GetComponentInChildren<Animator> ();
    }

    public void Update () { UpdateExtend (); }
    protected virtual void UpdateExtend () { }
}