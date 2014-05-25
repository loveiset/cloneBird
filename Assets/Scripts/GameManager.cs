using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public bool isStart = false;
    public bool runInToPipe = false;
    public bool runInToRoad = false;
    public bool die = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButton(0))
        {
            isStart = true;
        }
	}
}
