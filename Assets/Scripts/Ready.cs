using UnityEngine;
using System.Collections;

public class Ready : MonoBehaviour {
    public Animator ready;
    public GameManager gmr;

	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gmr.isStart == true)
        {
            ready.SetTrigger("start");
        }
	}
}
