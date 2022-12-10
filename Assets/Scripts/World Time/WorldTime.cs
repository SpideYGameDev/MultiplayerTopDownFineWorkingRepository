using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WorldTime : MonoBehaviour
{
    public event EventHandler<TimeSpan> WorldTimeChanged;
    [SerializeField]
    private float dayLength; // in seconds
    private TimeSpan currentTime;
    private float minuteLength => dayLength /WorldTimeConstants.MinutesinAday; 
    
    private void Start()
    {
        
        StartCoroutine(AddMinute());
    }
    private IEnumerator AddMinute()
    {
        currentTime += TimeSpan.FromMinutes(1);
        WorldTimeChanged?.Invoke(this,currentTime);
        yield return new WaitForSeconds(minuteLength);
        StartCoroutine(AddMinute());
    }
}
