using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using System;

public class CollectorController : Base
{
    private IJoysticktable _joysticktable;
    private ObjectType objectType = ObjectType.Collector;

    [Title("Player Joystick Values")]
    [SerializeField] float MoveSpeed;
    [SerializeField] float RotateSpeed;
    [Range(0, 1)]
    [SerializeField] float RotateSmooth;

    [Title("Point Values")]
    void Start()
    {
        _joysticktable = new CollectorJoystickController();
        _joysticktable.SetJoystickParameters(e_joystick, transform, e_rigidbody, MoveSpeed, RotateSpeed, RotateSmooth);
    }

    void Update()
    {
        _joysticktable.GetJoystickController();
    }

}
