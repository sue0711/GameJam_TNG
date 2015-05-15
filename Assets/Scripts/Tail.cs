using UnityEngine;
using System.Collections;

public class Tail : MonoBehaviour {


    public GameObject BeforeObj;
    public float distance = 2.0f;
    

	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {        
        this.transform.position = (this.transform.position 
                            - BeforeObj.transform.position).normalized * distance + BeforeObj.transform.position;
    }


   
}
