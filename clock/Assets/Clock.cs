using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform, minutesTransform, secondsTransform;
    const float degreesPerHour = 30f;
    const float degreesPerMinute = 6f;
    const float degreesPerSecond = 6f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime dt = DateTime.Now;
        hoursTransform.localRotation = Quaternion.Euler(0f, dt.Hour * degreesPerHour, 0f);
        minutesTransform.localRotation = Quaternion.Euler(0f, dt.Minute * degreesPerMinute, 0f);
        secondsTransform.localRotation = Quaternion.Euler(0f, dt.Second * degreesPerSecond, 0f);
    }
}
