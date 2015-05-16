using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_Collide : MonoBehaviour
{
    public int life;

    public Collider2D[] planets = new Collider2D[9];

    public GameObject countImg;

    public int score;

    Text scoreTxt;

    // Use this for initialization
    void Awake()
    {
        life = 3;

        planets[0] = GameObject.Find("Earth").GetComponent<Collider2D>();

        for (int i = 1; i < planets.Length; i++)
        {
            string nTs = i.ToString();
            planets[i] = GameObject.Find(nTs).GetComponent<Collider2D>(); 
        }

        scoreTxt = GameObject.Find("Canvas/Text/ScoreTxt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            Time.timeScale = 0;
        }

        scoreTxt.text = score.ToString();
    }


    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Obstacle")
        {
            Debug.Log(this.gameObject.name + "가 " + coll.gameObject.tag + "랑 충돌함");
            life--;
            OffCol();
        }
        else if(coll.gameObject.tag == "Item")
        {

            Debug.Log(this.gameObject.name + "가 " + coll.gameObject.tag + "을 먹음 짝짝짝");
            score += 10;
            
            GameObject effect;
            effect = Instantiate(countImg,coll.transform.position, coll.transform.rotation) as GameObject;
            coll.gameObject.SetActive(false);
            Destroy(effect, 1.0f);
        }
    }

    void OffCol()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].enabled = false;
        }
        this.GetComponent<SpriteRenderer>().color = Color.gray;
        Invoke("OnCol", 1.5f);
    }

    void OnCol()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].enabled = true;
        }
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
