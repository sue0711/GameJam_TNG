using UnityEngine;
using System.Collections;

public class testTR : MonoBehaviour {

    public float ScrollSpeed = 0.05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0, -1 * ScrollSpeed, 0);
        if (this.transform.position.y <= -12.0f)
        {
            this.transform.Translate(0, 24, 0);
        }
	}
}
