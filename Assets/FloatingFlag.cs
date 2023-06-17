using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FloatingFlag : MonoBehaviour
{
    public float waves = 1f;
    public float initialPhase = 0f;
    public float amplitude = 1f;
    public float angularFrequency = 1f;
    public float yPosition = 0f;


    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, amplitude * Mathf.Sin(waves*((angularFrequency * Time.time) + initialPhase)) + yPosition, transform.position.z);
        
    }
}
