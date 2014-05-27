using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public GameManager gmr;
    Animator gameOver;

	// Use this for initialization
	void Start () 
    {
        gameOver = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (gmr.die == true)
        {
            gameOver.SetTrigger("die");
        }
	}
}
