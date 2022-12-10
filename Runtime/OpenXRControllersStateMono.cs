using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenXRControllersStateMono : MonoBehaviour
{
    public OpenXRControllersState m_controllersState;
}

[System.Serializable]
public class OpenXRControllersState
{

    public ClassicVRControllersAsValue m_controllers;
}
[System.Serializable]
public class ClassicVRControllersAsValue
{
    public ClassicVRControllerAsValue m_left;
    public ClassicVRControllerAsValue m_right;
}
[System.Serializable]
public class ClassicVRControllerAsValue
{
    public bool m_isTracked;
    public bool m_isTopButtonDown;
    public bool m_isTopButtonTouch;
    public bool m_isDownButtonDown;
    public bool m_isDownButtonTouch;
    public bool m_isMenuButtonDown;
    public bool m_joystickButton;
    public bool m_joystickButtonTouch;
    public bool m_triggerTouch;
    public float m_triggerPercentState;
    public float m_gripPercentState;
    public Vector2 m_joystickAxes;
    public Vector2 m_oculusTouchpadAxes;
    public Vector3 m_controllerPosition;
    public Quaternion m_controllerRotation;
}
