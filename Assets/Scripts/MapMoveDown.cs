using UnityEngine;
using System.Collections;

public class MapMoveDown : MonoBehaviour {


    public GameObject map;
    public float speed;

	void Start () 
    {
        
        speed = 3.0f;
	}
	
	
	void Update () 
    {
        map.transform.Translate(Vector3.down * Time.deltaTime * speed);
	}


}
