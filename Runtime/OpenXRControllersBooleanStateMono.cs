using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenXRControllersBooleanStateMono : MonoBehaviour
{
    public OpenXRControllersBooleanState m_booleanState;
}

[System.Serializable]
public class OpenXRControllersBooleanState {

    public ClassicVRControllersAsBoolean m_controllers;
}
[System.Serializable]
public class ClassicVRControllersAsBoolean
{
    public ClassicVRControllerAsBoolean m_left;
    public ClassicVRControllerAsBoolean m_right;
}
[System.Serializable]
public class ClassicVRControllerAsBoolean
{
    public DefaultBooleanChangeListener m_isTracked;
    public DefaultBooleanChangeListener m_topButton;
    public DefaultBooleanChangeListener m_downButton;
    public DefaultBooleanChangeListener m_topButtonTouch;
    public DefaultBooleanChangeListener m_downButtonTouch;
    public DefaultBooleanChangeListener m_joystickButton;
    public DefaultBooleanChangeListener m_joystickButtonTouch;
    public DefaultBooleanChangeListener m_menuButton;
    public DefaultBooleanChangeListener m_gripButton;
    public DefaultBooleanChangeListener m_triggerButton;
    public DefaultBooleanChangeListener m_triggerButtonTouch;
    public FloatRangeToBoolean [] m_trigger= new FloatRangeToBoolean[] {
        new FloatRangeToBoolean(){ m_rangeLabel= "MiddleTriggerPression", m_minRange=0.2f, m_maxRange=0.8f},
        new FloatRangeToBoolean(){ m_rangeLabel= "MaxTriggerPression", m_minRange=0.8f, m_maxRange=1f}
    };
    public FloatRangeToBoolean [] m_grip = new FloatRangeToBoolean[] {
        new FloatRangeToBoolean(){ m_rangeLabel= "MiddleGripPression", m_minRange=0.2f, m_maxRange=0.8f},
        new FloatRangeToBoolean(){ m_rangeLabel= "MaxGripPression", m_minRange=0.8f, m_maxRange=1f}
    };
    public FloatRangeToBoolean[] m_joystickHorizontal = new FloatRangeToBoolean[] {
        new FloatRangeToBoolean(){ m_rangeLabel= "LeftMiddleJoystickPression", m_minRange=-0.2f, m_maxRange=-0.8f},
        new FloatRangeToBoolean(){ m_rangeLabel= "LeftMaxJoystickPression", m_minRange=-0.8f, m_maxRange=-1f},
        new FloatRangeToBoolean(){ m_rangeLabel= "RightMiddleJoystickPression", m_minRange=0.2f, m_maxRange=0.8f},
        new FloatRangeToBoolean(){ m_rangeLabel= "RightMaxJoystickPression", m_minRange=0.8f, m_maxRange=1f}
    };
    public FloatRangeToBoolean[] m_joystickVertical = new FloatRangeToBoolean[] {
        new FloatRangeToBoolean(){ m_rangeLabel= "DownMiddleJoystickPression", m_minRange=-0.2f, m_maxRange=-0.8f},
        new FloatRangeToBoolean(){ m_rangeLabel= "DownMaxJoystickPression", m_minRange=-0.8f, m_maxRange=-1f},
        new FloatRangeToBoolean(){ m_rangeLabel= "TopMiddleJoystickPression", m_minRange=0.2f, m_maxRange=0.8f},
        new FloatRangeToBoolean(){ m_rangeLabel= "TopMaxJoystickPression", m_minRange=0.8f, m_maxRange=1f}
    };
}

[System.Serializable]
public class FloatRangeToBoolean
{
    public string m_rangeLabel;
    public float m_minRange, m_maxRange;
    public DefaultBooleanChangeListener m_isInRange;
    
}