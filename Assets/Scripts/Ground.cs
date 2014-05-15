using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
    public Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    void FixedUpdate()
    {
        transform.position += velocity * Time.deltaTime;
        if (transform.position.x < -8.5f)
        {
            Vector3 pos = transform.position;
            pos.x = 9.17f;
            transform.position = pos;
        }
    }
}
