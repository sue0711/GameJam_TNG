using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Block_Loop : MonoBehaviour {
    public float Speed = 0.5f;
    public GameObject[] Block;
    public GameObject A_Zone;
    public GameObject B_Zone;

    public int mapCount = 0;
    public int currentPlanetNum = 0;

    public Sprite[] CollectBarImg = new Sprite[8];
    public Sprite[] PlanetImg = new Sprite[8];
    Sprite NextPlanetImg;
    

    Player_Collide earth;

	// Use this for initialization
	void Start () {
        earth = GameObject.FindGameObjectWithTag("Earth").GetComponent<Player_Collide>();

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
        mapCount++;
        int A = Random.Range(0, Block.Length);
        Debug.Log("A = " + A);
        B_Zone = Instantiate(Block[A], new Vector3(0, A_Zone.transform.position.y+15, 0), transform.rotation) as GameObject;





        if(mapCount % 5 == 0)
        {
            currentPlanetNum++;

           

            GameObject.Find("Canvas/PlanetGage").GetComponent<Image>().sprite
                = CollectBarImg[currentPlanetNum - 1];                
        }
    }
}
