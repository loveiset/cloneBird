using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {
    public Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position += velocity * Time.deltaTime;
	}


}
