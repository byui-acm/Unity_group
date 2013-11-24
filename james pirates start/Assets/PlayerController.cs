using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 5;
	public float rotationSpeed = 500;
	public float jumpspeed = .25f;
	public bool isJumping;
	Vector3 jumpVec;
	
	// Use this for initialization
	void Start () 
	{
		isJumping = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Moves player left and right.
    	float x = Input.GetAxis("Horizontal") * Time.smoothDeltaTime * speed;
    	
		if (isJumping == true)
		{
			//transform.position += jumpVec * Time.deltaTime;
			//jumpVec += (Vector3.down * Time.deltaTime);
		}
		
		else
		{
			
			//if (Input.GetKeyDown(KeyCode.Space))
			{
				//isJumping = true;
				//jumpVec = Vector3.up * (jumpspeed * Time.smoothDeltaTime);
				//transform.Translate(Vector3.up * jumpspeed * Time.deltaTime, Space.World);
				//rigidbody.AddForce(Vector3.up * jumpspeed);
			}
		}
		
		transform.Translate(x, 0, 0, Space.World); //move Player
		
		//rotate player
		if (x < 0)
		{
			Debug.Log("Rotating left");
			transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
		}
		else if (x > 0)
		{
			Debug.Log("Rotating right");
			transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed);
		}
		
		//move main camera
		//Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + 12.5f, transform.position.z - 2.5f);
		
		//move light volume
		//GameObject.FindGameObjectWithTag("Light volume").transform.position = transform.position;
		
		//Rotate Player to face where your mouse pointer is
		//Plane playerPlane = new Plane(Vector3.up, transform.position);
    	//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    	//var hitdist = 0.0f;
 
    	//if (playerPlane.Raycast(ray, out hitdist))
		//{
 	    //	var targetPoint = ray.GetPoint(hitdist);
        //	var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
        //	transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.smoothDeltaTime * 2);
			
			//rotate light volume
		//	GameObject.FindGameObjectWithTag("Light volume").transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.smoothDeltaTime * 2);
    	//}
	}
	
	void OnCollisionEnter (Collision hit)
	{
	    isJumping = false;
	    // check message upon collision for functionality  of code.
	    Debug.Log("I am colliding with: " + hit.gameObject);
	}
}
