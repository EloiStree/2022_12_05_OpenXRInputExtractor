using OpenXRActionInput;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class ClassicOpenXRToUnityEvent : MonoBehaviour
{
    public OpenXRControllersBooleanStateMono m_controllerBooleanListener;
    public OpenXRControllersStateMono m_controllerStateListener;
    public ClassicOpenXR m_input;

    void Awake()
    {
        m_input = new ClassicOpenXR();
        m_input.Enable();
        m_input.OculusSpecific.Enable();
        m_input.LeftInput.Enable();
        m_input.RightInput.Enable();
        m_input.LeftController.Enable();
        m_input.RightController.Enable();
        ClassicVRControllerAsBoolean leftBool = m_controllerBooleanListener.m_booleanState.m_controllers.m_left;
        ClassicVRControllerAsBoolean rightBool = m_controllerBooleanListener.m_booleanState.m_controllers.m_right;
        ClassicVRControllerAsValue leftInfo = m_controllerStateListener.m_controllersState.m_controllers.m_left;
        ClassicVRControllerAsValue rightInfo = m_controllerStateListener.m_controllersState.m_controllers.m_right;
        m_input.LeftInput.IsTracked.performed += (v) => ReadLeftIsTrack(v, leftBool, leftInfo);
        m_input.LeftInput.IsTracked.canceled += (v) => ReadLeftIsTrack(v, leftBool, leftInfo);

        m_input.LeftInput.TopButton.performed += (v) => ReadLeftTopButtonIsDown(v, leftBool, leftInfo);
        m_input.LeftInput.TopButton.canceled += (v) => ReadLeftTopButtonIsDown(v, leftBool, leftInfo);

        m_input.LeftInput.DownButton.performed += (v) => ReadLeftDownButtonIsDown(v, leftBool, leftInfo);
        m_input.LeftInput.DownButton.canceled += (v) => ReadLeftDownButtonIsDown(v, leftBool, leftInfo);

        m_input.LeftInput.TopButtonOver.performed += (v) => ReadLeftTopIsTouched(v, leftBool, leftInfo);
        m_input.LeftInput.TopButtonOver.canceled += (v) => ReadLeftTopIsTouched(v, leftBool, leftInfo);

        m_input.LeftInput.DownButtonOver.performed += (v) => ReadLeftDownIsTouch(v, leftBool, leftInfo);
        m_input.LeftInput.DownButtonOver.canceled += (v) => ReadLeftDownIsTouch(v, leftBool, leftInfo);

        m_input.LeftInput.JoystickButtonPressed.performed += (v) => ReadIsLeftJoystickButtonDown(v, leftBool, leftInfo);
        m_input.LeftInput.JoystickButtonPressed.canceled += (v) => ReadIsLeftJoystickButtonDown(v, leftBool, leftInfo);

        m_input.LeftInput.JoystickButtonOver.performed += (v) => ReadIsLeftJoystickButtonTouch(v, leftBool, leftInfo);
        m_input.LeftInput.JoystickButtonOver.canceled += (v) => ReadIsLeftJoystickButtonTouch(v, leftBool, leftInfo);


        m_input.LeftInput.GripPercent.performed += (v) => ReadLeftGripValue(v, leftBool, leftInfo);
        m_input.LeftInput.GripPercent.canceled += (v) => ReadLeftGripValue(v, leftBool, leftInfo);

        m_input.LeftInput.TriggerPercent.performed += (v) => ReadLeftTriggerValue(v, leftBool, leftInfo);
        m_input.LeftInput.TriggerPercent.canceled += (v) => ReadLeftTriggerValue(v, leftBool, leftInfo);

        m_input.LeftInput.TriggerOver.performed += (v) => ReadIsLeftTriggerTouch(v, leftBool, leftInfo);
        m_input.LeftInput.TriggerOver.canceled += (v) => ReadIsLeftTriggerTouch(v, leftBool, leftInfo);

        m_input.LeftInput.Joystick2D.performed += (v) => ReadLeftJoystick2D(v, leftBool, leftInfo);
        m_input.LeftInput.Joystick2D.canceled += (v) => ReadLeftJoystick2D(v, leftBool, leftInfo);

        m_input.OculusSpecific.LeftTouchPad.performed += (v) => ReadLeftOculusPad(v, leftInfo);
        m_input.OculusSpecific.LeftTouchPad.canceled += (v) => ReadLeftOculusPad(v, leftInfo);

        m_input.LeftController.Position.performed += (v) => ReadLeftControllerPosition(v, leftInfo);
        m_input.LeftController.Position.canceled += (v) => ReadLeftControllerPosition(v, leftInfo);

        m_input.LeftController.Rotation.performed += (v) => ReadLeftControllerRotation(v, leftInfo);
        m_input.LeftController.Rotation.canceled += (v) => ReadLeftControllerRotation(v, leftInfo);





        m_input.RightInput.IsTracked.performed += (v) => ReadLeftIsTrack(v, rightBool, rightInfo);
        m_input.RightInput.IsTracked.canceled += (v) => ReadLeftIsTrack(v, rightBool, rightInfo);
               
        m_input.RightInput.TopButton.performed += (v) => ReadLeftTopButtonIsDown(v, rightBool, rightInfo);
        m_input.RightInput.TopButton.canceled += (v) => ReadLeftTopButtonIsDown(v, rightBool, rightInfo);
              
        m_input.RightInput.DownButton.performed += (v) => ReadLeftDownButtonIsDown(v, rightBool, rightInfo);
        m_input.RightInput.DownButton.canceled += (v) => ReadLeftDownButtonIsDown(v, rightBool, rightInfo);
               
        m_input.RightInput.TopButtonOver.performed += (v) => ReadLeftTopIsTouched(v, rightBool, rightInfo);
        m_input.RightInput.TopButtonOver.canceled += (v) => ReadLeftTopIsTouched(v, rightBool, rightInfo);
               
        m_input.RightInput.DownButtonOver.performed += (v) => ReadLeftDownIsTouch(v, rightBool, rightInfo);
        m_input.RightInput.DownButtonOver.canceled += (v) => ReadLeftDownIsTouch(v, rightBool, rightInfo);
                
        m_input.RightInput.JoystickButtonPressed.performed += (v) => ReadIsLeftJoystickButtonDown(v, rightBool, rightInfo);
        m_input.RightInput.JoystickButtonPressed.canceled += (v) => ReadIsLeftJoystickButtonDown(v, rightBool, rightInfo);
                
        m_input.RightInput.JoystickButtonOver.performed += (v) => ReadIsLeftJoystickButtonTouch(v, rightBool, rightInfo);
        m_input.RightInput.JoystickButtonOver.canceled += (v) => ReadIsLeftJoystickButtonTouch(v, rightBool, rightInfo);


        m_input.RightInput.GripPercent.performed += (v) => ReadLeftGripValue(v, rightBool, rightInfo);
        m_input.RightInput.GripPercent.canceled += (v) => ReadLeftGripValue(v, rightBool, rightInfo);
              
        m_input.RightInput.TriggerPercent.performed += (v) => ReadLeftTriggerValue(v, rightBool, rightInfo);
        m_input.RightInput.TriggerPercent.canceled += (v) => ReadLeftTriggerValue(v, rightBool, rightInfo);
              
        m_input.RightInput.TriggerOver.performed += (v) => ReadIsLeftTriggerTouch(v, rightBool, rightInfo);
        m_input.RightInput.TriggerOver.canceled += (v) => ReadIsLeftTriggerTouch(v, rightBool, rightInfo);
               
        m_input.RightInput.Joystick2D.performed += (v) => ReadLeftJoystick2D(v, rightBool, rightInfo);
        m_input.RightInput.Joystick2D.canceled += (v) => ReadLeftJoystick2D(v, rightBool, rightInfo);

        m_input.OculusSpecific.RightTouchPad.performed += (v) => ReadLeftOculusPad(v, rightInfo);
        m_input.OculusSpecific.RightTouchPad.canceled += (v) => ReadLeftOculusPad(v, rightInfo);

        m_input.RightController.Position.performed += (v) => ReadLeftControllerPosition(v, rightInfo);
        m_input.RightController.Position.canceled += (v) => ReadLeftControllerPosition(v, rightInfo);
             
        m_input.RightController.Rotation.performed += (v) => ReadLeftControllerRotation(v, rightInfo);
        m_input.RightController.Rotation.canceled += (v) => ReadLeftControllerRotation(v, rightInfo);






    }

    private static void ReadLeftControllerRotation(InputAction.CallbackContext v, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_controllerRotation = v.ReadValue<Quaternion>();
    }

    private static void ReadLeftControllerPosition(InputAction.CallbackContext v, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_controllerPosition = v.ReadValue<Vector3>();
    }

    private static void ReadLeftOculusPad(InputAction.CallbackContext v, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_oculusTouchpadAxes = v.ReadValue<Vector2>();
    }

    private static void ReadLeftJoystick2D(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_joystickAxes = v.ReadValue<Vector2>();
        float h = leftInfo.m_joystickAxes.x;

        foreach (var item in leftBool.m_joystickHorizontal)
            item.m_isInRange.SetBoolean(IsInRange(h, item));

        float vertical = leftInfo.m_joystickAxes.y;

        foreach (var item in leftBool.m_joystickVertical)
            item.m_isInRange.SetBoolean(IsInRange(vertical, item));
    }

    private static void ReadIsLeftTriggerTouch(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftBool.m_triggerButtonTouch.SetBoolean(v.ReadValue<float>() > 0.5f);
        leftInfo.m_triggerTouch = v.ReadValue<float>() > 0.5f;
    }

    private static void ReadLeftTriggerValue(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        float value = v.ReadValue<float>();
        leftInfo.m_triggerPercentState = value;
        leftBool.m_triggerButton.SetBoolean(value > 0.01f);
        foreach (var item in leftBool.m_trigger)
            item.m_isInRange.SetBoolean(IsInRange(value, item));
    }

    private static void ReadLeftGripValue(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        float value = v.ReadValue<float>();
        leftInfo.m_gripPercentState = value;
        leftBool.m_gripButton.SetBoolean(value > 0.01f);
        foreach (var item in leftBool.m_grip)
            item.m_isInRange.SetBoolean(IsInRange(value, item));
    }

    private static bool IsInRange(float value, FloatRangeToBoolean item)
    {
        return (value >= item.m_minRange && value <= item.m_maxRange) || (value >= item.m_maxRange && value <= item.m_minRange);
    }

    private static void ReadIsLeftJoystickButtonTouch(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_joystickButtonTouch = v.ReadValue<float>() > 0.5f;
        leftBool.m_joystickButtonTouch.SetBoolean(v.ReadValue<float>() > 0.5f);
    }

    private static void ReadIsLeftJoystickButtonDown(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_joystickButton = v.ReadValue<float>() > 0.5f;
        leftBool.m_joystickButton.SetBoolean(v.ReadValue<float>() > 0.5f);
    }

    private static void ReadLeftDownIsTouch(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_isDownButtonTouch = v.ReadValue<float>() > 0.5f;
        leftBool.m_downButtonTouch.SetBoolean(v.ReadValue<float>() > 0.5f);
    }

    private static void ReadLeftTopIsTouched(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_isTopButtonTouch = v.ReadValue<float>() > 0.5f;
        leftBool.m_topButtonTouch.SetBoolean(v.ReadValue<float>() > 0.5f);
    }

    private static void ReadLeftDownButtonIsDown(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_isDownButtonDown = v.ReadValue<float>() > 0.5f;
        leftBool.m_downButton.SetBoolean(v.ReadValue<float>() > 0.5f);
    }

    private static void ReadLeftTopButtonIsDown(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_isTopButtonDown = v.ReadValue<float>() > 0.5f;
        leftBool.m_topButton.SetBoolean(v.ReadValue<float>() > 0.5f);
    }

    private static void ReadLeftIsTrack(InputAction.CallbackContext v, ClassicVRControllerAsBoolean leftBool, ClassicVRControllerAsValue leftInfo)
    {
        leftInfo.m_isTracked = v.ReadValue<float>() > 0.5f;
        leftBool.m_isTracked.SetBoolean(v.ReadValue<float>() > 0.5f);
    }
}
