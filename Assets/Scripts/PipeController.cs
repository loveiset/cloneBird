using UnityEngine;
using System.Collections;

public class PipeController : MonoBehaviour {
    [SerializeField]
    Pipes[] pipes;

    public GameManager gmr;

	// Use this for initialization
	void Start () 
    {
        for (int i = 0; i < pipes.Length; i++)
        {
            pipes[i].GetComponent<Pipes>().enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gmr.isStart == true)
        {
            if (gmr.die == true)
            {
                for (int i = 0; i < pipes.Length; i++)
                {
                    pipes[i].GetComponent<Pipes>().enabled = false;
                }
                return;
            }
            for (int i = 0; i < pipes.Length; i++)
            {
                pipes[i].GetComponent<Pipes>().enabled = true;
            }
        }
	}
}
