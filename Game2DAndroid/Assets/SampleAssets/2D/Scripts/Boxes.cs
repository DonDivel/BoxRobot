using UnityEngine;
using System.Collections;
using UnitySampleAssets._2D;

public class Boxes : MonoBehaviour {

    public  GameObject exp;
    PlatformerCharacter2D sc;
	// Use this for initialization
	void Start () {
	sc = GameObject.Find("2DCharacter").GetComponent<PlatformerCharacter2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "box")
        //   coll.gameObject.SendMessage("ApplyDamage", 10);
        {

            //anim.SetTrigger("colusion");
            
            Destroy(this.gameObject);
            Instantiate(exp, transform.position, Quaternion.identity);
            sc.boxColid += 1;
        }
        
    }
}
