using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public GameObject joystickHandle;

    public static float horizontal;
    public static float vertical;

    public static bool buttonA = false;
    public static bool buttonB = false;

    private void Update()
    {
        Horizontal();
        Vertical();
    }

    public void Horizontal()
    {
        horizontal = joystickHandle.transform.localPosition.x;
    }

    public void Vertical()
    {
        vertical = joystickHandle.transform.localPosition.y;
    }

    public void ButtonA()
    {
        buttonA = true;
    }

    public void ButtonB()
    {
        buttonB = true;
    }

}
