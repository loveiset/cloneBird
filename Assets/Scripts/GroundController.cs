using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {
    public GameManager gmr;
    [SerializeField]
    Ground[] grounds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gmr.die == true)
        {
            for (int i = 0; i < grounds.Length; i++)
            {
                grounds[i].GetComponent<Ground>().enabled = false;
            }
        }
	}
}
