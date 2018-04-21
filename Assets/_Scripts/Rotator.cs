﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float m_Speed = 20f;

    private Vector3 m_RotationDirection = Vector3.up;

    public void ToggleRotationDirection()
    {
        Debug.Log("Toggling rotation direction");

        if (m_RotationDirection == Vector3.up)
        {
            m_RotationDirection = Vector3.down;
        }
        else
        {
            m_RotationDirection = Vector3.up;
        }
    }

    void Update()
    {
        transform.Rotate(m_RotationDirection * Time.deltaTime * m_Speed);
    }
}
