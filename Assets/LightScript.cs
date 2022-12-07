using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light myLight;

    //range variables
    float deltatime=Time.deltaTime;
    public float rangeSpeed = 1.0f;
    public float maxRange = 1.0f;
    public bool change =true;
    public float timesampler = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
         //myLight.intensity=Mathf.PingPong(Time.time,8);
    }

    // Update is called once per frame
    void Update()
    {
         /*if(change==true){
                myLight.intensity=Mathf.PingPong(Time.time,4);
            }*/
       timesampler=timesampler+deltatime;
        for(int i=0;i<4;i++){
            if(change==true){
                myLight.intensity=Mathf.PingPong(Time.time,8);
            }
            if(change==false){
                myLight.intensity=Mathf.PingPong(Time.time,8);
            }
            if(timesampler>4){
                timesampler=0;
                if(change==true){
                change=false;
                }
                if(change==false){
                change=true;
                }
            }
        }
    }
}
