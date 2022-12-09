using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light myLight;
    public AnimationCurve ac;

    public float intensityMultiplier;

    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        float value=ac.Evaluate(Time.time);
        float finalValue=value*intensityMultiplier;
        
        myLight.intensity=finalValue;
    }    
}
