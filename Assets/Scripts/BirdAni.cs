using UnityEngine;
using System.Collections;

public class BirdAni : MonoBehaviour {
    public GameManager gmr;
    public GameObject scoreObject;
    Score score;
    public AudioClip success;
    public AudioClip fail;
    public Bird bird;

	// Use this for initialization
	void Start () {
        score = scoreObject.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.CompareTo("pipe") == 0)
        {
            if (gmr.die != true)
            {
                gmr.die = true;
                audio.PlayOneShot(fail);
            }
        }
        if (other.gameObject.tag.CompareTo("ground") == 0)
        {
            
            if (gmr.die == true)
            {
                bird.velocity = Vector3.zero;
                bird.GetComponent<Bird>().enabled = false;
            }
            else
            {
                gmr.die = true;
                audio.PlayOneShot(fail);
                bird.velocity = Vector3.zero;
                bird.GetComponent<Bird>().enabled = false;

            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.CompareTo("gap") == 0)
        {
            if (gmr.die != true)
            {
                Debug.Log("success");
                score.ShowScore();
                audio.PlayOneShot(success);
            }
        }
    }


    void OnGUI()
    {
        if (gmr.die==true)
        {
            if (GUI.Button(new Rect(50, 50, 100, 50), "play again"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    void FixedUpdate()
    {
        
    }
}
