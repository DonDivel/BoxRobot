using UnityEngine;
using System.Collections;

public class BulletLeft : MonoBehaviour {
    public float speed = 100f;
    private Animator anim;
    public GameObject o;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed);
	}
    void OnCollisionEnter2D(Collision2D coll)
    {
       
         //   anim.SetTrigger("colusion");
            Destroy(this.gameObject);
            Instantiate(o, transform.position, Quaternion.identity);
        
    }
}
