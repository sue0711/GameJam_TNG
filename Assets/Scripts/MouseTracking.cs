using UnityEngine;
using System.Collections;

public class MouseTracking : MonoBehaviour {

    float Distance = 10;

    public bool isFree;

    int freeCnt;

    PointEffector2D blackHolePE;

    Rigidbody2D rb;

    // Use this for initialization
	void Start () {
        isFree = true;
        freeCnt = 0;
        blackHolePE = GameObject.Find("Hole").GetComponent<PointEffector2D>();
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (freeCnt >= 3 && !isFree)
        {
            blackHolePE.forceMagnitude = 1000;
        }
        
        /*
        if (isFree)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

                transform.position = objPosition;
            }
        }
        */
        if (!isFree)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                freeCnt++;
                Debug.Log("freeCnt = " + freeCnt);
                //blackHolePE.forceMagnitude += 50;
            }

            float distance = Vector2.Distance(blackHolePE.gameObject.transform.position, this.transform.position);
            Debug.Log(distance);

            if (distance > 3.5f)
            {
                isFree = true;
                rb.isKinematic = true;
                rb.isKinematic = false;
                blackHolePE.forceMagnitude = -50;
                freeCnt = 0;
                Debug.Log("freeCnt = " + freeCnt + "초기화됨");
            }
        }
	}
   
    void OnMouseDrag()
    {
        if (isFree)
        {
            if ((Input.mousePosition.x < (Screen.width - 3)) && (Input.mousePosition.x > 3) && (Input.mousePosition.y < (Screen.height - 3)) && (Input.mousePosition.y > 3))
            {             
                Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

                transform.position = objPosition;
            }

        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BlackHole")
        {
            isFree = false;
        }

    }
}
