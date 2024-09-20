using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class open_door : MonoBehaviour
{
    Vector3 StartLocation;
    Vector3 EndLocation;
    float progress = 0;
    bool held = false;

    [SerializeField] private Vector3 DoorOffset = Vector3.zero;

    // Start is called before the first frame update

    public void DoorOpen()
    {
        held = true;
    }

    public void DoorClose()
    {
        held = false;
    }

    void Start()
    {
        StartLocation = transform.position;
        EndLocation = transform.position + DoorOffset;
    }

    // Update is called once per frame
    void Update()
    {
        if (held)
        {
            progress += Time.deltaTime;
            if (progress > 1) progress = 1;
            transform.position = Vector3.Lerp(StartLocation, EndLocation, progress);
        }
        else
        {
            progress -= Time.deltaTime;
            if (progress < 0) progress = 0;
            transform.position = Vector3.Lerp(StartLocation, EndLocation, progress);
        }
    }
}