using UnityEngine;
using System.Collections;

public class BirdAni : MonoBehaviour {
    public static bool die = false;

	// Use this for initialization
	void Start () {
        die = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.CompareTo("pipe") == 0)
        {
            Debug.Log("die");
            die = true;
            //Application.LoadLevel(Application.loadedLevel);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.CompareTo("gap") == 0)
        {
            Debug.Log("success");
            //audio.PlayOneShot(success);
        }
    }

    void OnGUI()
    {
        if (die)
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
