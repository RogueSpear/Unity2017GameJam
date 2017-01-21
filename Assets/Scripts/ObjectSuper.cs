using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSuper : MonoBehaviour
{

    public bool blade;
    private float direction;
    private Rigidbody2D obj;
    private bool colPlayer;
    //public WaveAttack wave;
    //public Victim[] victims;
    public PlayerController Player; 
    
	// Use this for initialization
	void Start ()
    {
        obj = gameObject.GetComponent<Rigidbody2D>();
        float weight = obj.mass;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Hover();
        }

    }
    void OnCollisionEnter(Collision col)
    {
        //if(col.CompareTag("Player)
        if(col.gameObject.name == Player.name)
        {
            Hover();
            colPlayer = true;
        }
    }
    void OnCollisionExit(Collision col)
    {
        colPlayer = false;
    }

    Vector2 getDirection()
    {
        Vector2 playerpos = Player.transform.position;
        Vector2 objpos = obj.transform.position;
        Vector2 newVector = objpos - playerpos;
        Debug.Log("Player position is " + playerpos);
        Debug.Log("Object position is " + objpos);
        Debug.Log("newVector is " + newVector.normalized);
        return newVector.normalized;
    }

    void Hover()
    {
        Debug.Log("Hover was called");
        Vector2 here = obj.transform.position;
        var vectorToPlayer = getDirection();
        Debug.Log("move is " + here);
        Debug.Log("thingy is " + vectorToPlayer);
        Debug.Log("Hover is " + (here += vectorToPlayer * 10 * Time.deltaTime));
        obj.AddForce((vectorToPlayer * 2));
    }

    void Chib()
    {

    }
}
