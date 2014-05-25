using UnityEngine;
using System.Collections;

public class Pipes : MonoBehaviour {
    public Vector3 velocity = Vector3.zero;
    public GameManager gmr;

	// Use this for initialization
	void Start () 
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(4.3f, 9.9f);
        transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    void FixedUpdate()
    {
        if (gmr.isStart)
        {
            transform.position += velocity * Time.deltaTime;
            if (transform.position.x <= -5.1f)
            {
                Vector3 pos = transform.position;
                pos.x = 9.9f;
                pos.y = Random.Range(4.3f, 9.9f);
                transform.position = pos;
            }
        }
    }
}
