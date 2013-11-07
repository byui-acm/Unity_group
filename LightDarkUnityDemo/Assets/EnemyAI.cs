using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
	private float distance;
	public Transform target;
	private float lookAtDistance = 15;
	private float attackDistance = 10;
	private float moveSpeed = 2;
	private float damping = 6;
	private bool isItAttacking = false;
	public bool isObserved = false;
	
	// Update is called once per frame
	void Update ()
	{
		distance = Vector3.Distance(target.position, transform.position);
		
		if (isObserved)
		{
			renderer.material.color = Color.magenta;
		}
		else
		{
			if (distance < lookAtDistance)
			{
				isItAttacking = false;
				renderer.material.color = Color.yellow;
				lookAt();
			}
			
			if (distance > lookAtDistance)
			{
				renderer.material.color = Color.green;	
			}
			
			if (distance < attackDistance)
			{
				attack();	
			}
			
			if (isItAttacking)
			{
				renderer.material.color = Color.red;	
			}
		}
	}
	
	private void lookAt()
	{
		var rotation = Quaternion.LookRotation(target.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
	}
	
	private void attack()
	{
		isItAttacking = true;
		renderer.material.color = Color.red;
		
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}
	
	public void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			target.renderer.material.color = Color.red; //represents death
			isObserved = true;
		}
	}
	
	//This function is only here for debugging
	public void OnCollisionExit(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			target.renderer.material.color = Color.blue;
			isObserved = false;
		}
	}
	
	public void OnTriggerStay(Collider collider)
	{
		Debug.Log(collider.gameObject);
		if (collider.gameObject.tag == "Light volume")
		{
			isObserved = true;
		}
	}
	
	public void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.tag == "Light volume")
		{
			isObserved = false;
		}
	}
}
