using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightadjust1 : MonoBehaviour
{
    // Start is called before the first frame update

    Light light;
    public float minIntensity = 0.0f;
    public float maxIntensity = 6.7f;
    public float frequency = 0.01f;
    public int a = 1;
    

    void Start()
    {

        light = GetComponent<Light>();
        InvokeRepeating("intensity", 2,1);

    }

    // Update is called once per frame
    void Update()
    {
        //float x = (Time.time + phase) * frequency;
        //x = x-Mathf.Floor(x); // normalized value to 0..1
        //light.intensity = maxIntensity * Mathf.Sin(2 * Mathf.PI * x) + minIntensity;

        


        //light.intensity = minIntensity + frequency;
        //frequency++;
        //if(maxIntensity==6.7f)
        //{

        //}

        

        
    }

    void intensity()
    {

        //light.intensity = maxIntensity;
        //frequency++;
        //if (light.intensity == 6.7f)
        //{
        //    light.intensity = 0.0f;
        //    }
        
        if(a==1)
        {
            light.intensity = minIntensity;
            
        }
        if(a==0)
        {
            light.intensity = maxIntensity;
        }
       
        

    }




}
