using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerScaler : MonoBehaviour
{
    public AnimationCurve ac;
    public float intensityMultiplier=1;

    Vector3 startingScale;

    // Start is called before the first frame update
    void Start()
    {
        startingScale=this.transform.localScale; //store for later
    }

    // Update is called once per frame
    void Update()
    {
        float value=ac.Evaluate(Time.time);
        float finalScale=value*intensityMultiplier;
        Vector3 computedScale=startingScale*finalScale;

        this.transform.localScale=computedScale;
    }
}
