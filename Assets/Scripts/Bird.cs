using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    public Vector3 velocity = Vector3.zero;
    public Vector3 gravity = Vector3.zero;
    public Vector3 flyVelocity = Vector3.zero;
    public float maxSpeed = 20f;
    bool isFly = false;
    public Animator bird;
    public AudioClip fly;

    public GameManager gmr;
    

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
            audio.PlayOneShot(fly);
        }
	}

    void FixedUpdate()
    {
        if (gmr.isStart)
        {
            bird.SetTrigger("start");

            velocity += gravity * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
            if (isFly && gmr.die != true)
            {
                isFly = false;
                velocity = flyVelocity;
            }

            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);

            float angle = 10;
            if (velocity.y < -3f)
            {
                if (gmr.die)
                {
                    angle = -90;
                }
                else
                {
                    angle = Mathf.Lerp(10, -90, -(3 + velocity.y) / 10);
                    //Debug.Log(angle);
                }
            }
            transform.localRotation = Quaternion.Euler(0, 0, angle);
        }
    }
    

}
