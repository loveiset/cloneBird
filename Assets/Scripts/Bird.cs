using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {
    Vector3 velocity = Vector3.zero;
    public Vector3 gravity = Vector3.zero;
    public Vector3 flyVelocity = Vector3.zero;
    public float maxSpeed = 20f;
    bool isFly = false;
    public Animator bird;

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
        }
	}

    void FixedUpdate()
    {
        if (gmr.isStart)
        {
            bird.SetTrigger("start");
            if (gmr.die)
            {
                bird.SetTrigger("die");
            }

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
                angle = Mathf.Lerp(10, -90, -(3 + velocity.y) / 10);
                //Debug.Log(angle);
            }
            transform.localRotation = Quaternion.Euler(0, 0, angle);
        }
    }
    

}
