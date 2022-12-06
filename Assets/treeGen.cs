using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeGen : MonoBehaviour
{
   
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        //Insert console debug statement or print statement
        //look up instantiate in api documentation
        //Debug.Log("test");
        
       for(int i =0;i<60;i++){
        GameObject Left = Instantiate(tree);
        Vector3 posPosition = new Vector3(Random.Range(-100,100f),-2,Random.Range(25,100f));
        Left.transform.position=posPosition;

        GameObject Right = Instantiate(tree);
        Vector3 negPosition = new Vector3(Random.Range(-100,100f),-2,Random.Range(-100,-35f));
        Right.transform.position=negPosition;
         

        GameObject Bottom = Instantiate(tree);
        Vector3 Position = new Vector3(Random.Range(-100,-20f),-2,Random.Range(-100,100f));
        Bottom.transform.position=Position;

        GameObject Top = Instantiate(tree);
        Vector3 Position1 = new Vector3(Random.Range(20,100f),-2,Random.Range(-100,100f));
        Top.transform.position=Position1;
       } 
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
