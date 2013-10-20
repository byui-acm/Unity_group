using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 5;
	public float rotationSpeed = 5;
	
	// Use this for initialization
	void Start () {	}
	
	// Update is called once per frame
	void Update ()
	{
		// Moves player left, right, up, down. No collision.
    	float x = Input.GetAxis("Horizontal") * Time.smoothDeltaTime * speed;
    	float y = Input.GetAxis("Vertical") * Time.smoothDeltaTime * speed;

		transform.Translate(x, 0, y, Space.World); //move Player
		
		//move main camera
		Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + 9.5f, transform.position.z - 2.5f);

		//Rotate Player to face where your mouse pointer is
		Plane playerPlane = new Plane(Vector3.up, transform.position);
    	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    	var hitdist = 0.0f;
 
    	if (playerPlane.Raycast(ray, out hitdist))
		{
 	    	var targetPoint = ray.GetPoint(hitdist);
        	var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
        	transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.smoothDeltaTime * 2);
    	}
	}
}
