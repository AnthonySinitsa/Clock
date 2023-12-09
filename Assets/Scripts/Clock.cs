using System;
using UnityEngine;


public class Clock : MonoBehaviour{
    float hoursToDegrees = -30
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;

    void Awake () {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * DateTime.Now.Hour);
    }
}
