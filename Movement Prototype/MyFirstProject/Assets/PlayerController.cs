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

  		foreach(var thing in GameObject.FindGameObjectsWithTag("Player"))
		{
			thing.transform.Translate(x, 0, y, Space.World); //move Player
		}
		
		Camera.mainCamera.transform.Translate(x, y, 0, Space.Self); //move main camera
		
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
