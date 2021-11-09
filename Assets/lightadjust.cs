using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightadjust : MonoBehaviour
{
    // Start is called before the first frame update

    public Light mylight;

    public bool changerange = false;
    public float rangespeed = 1.0f;
    public float maxrange = 10.0f;

    public bool changeintensity = false;
    public float intensityspeed = 1.0f;
    public float maxintensity = 23.0f;

    float starttime;

    void Start()
    {
        mylight = GetComponent<Light>();
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (changeintensity)
        {
            mylight.intensity = Mathf.PingPong(Time.time * intensityspeed, maxintensity);
        }
    }
}
