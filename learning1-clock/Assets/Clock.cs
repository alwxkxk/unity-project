using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using static UnityEngine.Quaternion;


public class Clock : MonoBehaviour
{
    public Image imgHour;
    public Image imgMinute;
    public Image imgSecond;

    private const float hoursToDegrees = -30f;// 1小时旋转角度
    private const float minutesToDegrees = -6f;
    private const float secondsToDegrees = -6f;

    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan timeSpan = DateTime.Now.TimeOfDay;
        //Debug.Log((float)timeSpan.TotalHours);
        imgHour.rectTransform.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * (float)timeSpan.TotalHours);
        imgMinute.rectTransform.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * (float)timeSpan.TotalMinutes);
        imgSecond.rectTransform.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * (float)timeSpan.TotalSeconds);


    }
}
