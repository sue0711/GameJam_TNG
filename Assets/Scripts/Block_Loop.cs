using UnityEngine;
using System.Collections;

public class Block_Loop : MonoBehaviour {
    public float Speed = 0.2f;
    public GameObject[] Block;
    public GameObject A_Zone;
    public GameObject B_Zone;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move()
    {
        A_Zone.transform.Translate(Vector3.down * Speed * Time.deltaTime * 8);
        B_Zone.transform.Translate(Vector3.down * Speed * Time.deltaTime * 8);

        if (B_Zone.transform.position.y <= 0)
        {
            Destroy(A_Zone);

            A_Zone = B_Zone;
            Make();
        }
    }

    void Make()
    {
        int A = Random.Range(0, Block.Length);
        Debug.Log("A = " + A);
        B_Zone = Instantiate(Block[A], new Vector3(0, A_Zone.transform.position.y+12, 0), transform.rotation) as GameObject;
    }
}
