using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightadjust : MonoBehaviour
{
    // Start is called before the first frame update

    public Light mainlight;
    public bool c=true;
    
    void Start()
    {
        Invoke("changeposition",2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeposition()
    {
        
        
        if(c)
        {
            this.transform.position = new Vector3(0.555999994f, -5.75f, -0.356999993f);
        }

        //if(c!)
        //{
        //    this.transform.position = new Vector3(0.555999994f, 1.30700004f, -0.356999993f);
        //    c = false;
        //}
        
        //this.transform.position = new Vector3(0.555999994f, -5.75f, -0.356999993f);
        //this.transform.position = new Vector3(0.555999994f, 1.30700004f, -0.356999993f);
        //InvokeRepeating("change", 0, 2);
    }

    
}
