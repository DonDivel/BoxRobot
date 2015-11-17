using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
    public GameObject Bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "bullet")
        //   coll.gameObject.SendMessage("ApplyDamage", 10);
        {

            //anim.SetTrigger("colusion");
            Destroy(this.gameObject);
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
       
    }
}
