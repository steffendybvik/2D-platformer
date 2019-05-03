using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbstractBehavior : MonoBehaviour
{
    protected GameObject character;
    protected Rigidbody2D rigidbody2D;
    protected Animator animator;

    protected float gsp = 0f;
    protected float acc = 0.2f;
    protected float dec = 0.5f;
    protected float frc = 5f;
    protected float top = 10f;

    public void Awake()
    {
        character = this.gameObject;
        rigidbody2D = character.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponentInChildren<Animator>();
        AwakeExtend();
    }

    public void Start() { StartExtend(); }
    public void Update() { UpdateExtend(); }
    protected virtual void AwakeExtend() { }
    protected virtual void StartExtend() { }
    protected virtual void UpdateExtend() { }
}
