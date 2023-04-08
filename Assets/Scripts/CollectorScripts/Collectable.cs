using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IJoysticktable
{
    void GetJoystickController();

    void SetJoystickParameters(Joystick joystick, Transform transform, Rigidbody rigidbody, float moveSpeed, float rotateSpeed, float rotateSmooth);
}

public interface IPlayerMoveController
{
    void GetPlayerMoveController();
}

public interface IInteract
{
    void Interact(ObjectType type, Transform transform, Action<ObjectType, Transform> action);
}