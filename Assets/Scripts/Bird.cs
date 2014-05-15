using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    Vector3 velocity = Vector3.zero;
    public Vector3 gravity = Vector3.zero;
    public Vector3 flyVelocity = Vector3.zero;
    public float maxSpeed = 20f;
    bool isFly = false;
    public AudioClip success;
    

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButtonDown(0))
        {
            isFly = true;
        }
	}

    void FixedUpdate()
    {
        velocity += gravity * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        if (isFly)
        {
            isFly = false;
            velocity = flyVelocity;
        }

        //velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

        float angle = 10;
        if (velocity.y < -1f)
        {
            angle = Mathf.Lerp(10, -90, -velocity.y / 10);
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.CompareTo("pipe") == 0)
        {
            Debug.Log("die");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag.CompareTo("gap") == 0)
        {
            Debug.Log("success");
            audio.PlayOneShot(success);
        }
    }

}
