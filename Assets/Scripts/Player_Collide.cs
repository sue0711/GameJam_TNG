using UnityEngine;
using System.Collections;


public class Player_Collide : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Obstacle")
        {
            Debug.Log(this.gameObject.name + "가 " + coll.gameObject.tag + "랑 충돌함");
        }
    }

}
