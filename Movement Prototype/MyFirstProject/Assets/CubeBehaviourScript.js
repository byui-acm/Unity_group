#pragma strict

var walkspeed: float = 5.0;

function Start() {



}

function Update() {

    rigidbody.freezeRotation = true;

    if (Input.GetKey("up"))//move up
    {
    	transform.Translate(Vector3(0, 0, 1) * Time.deltaTime * walkspeed);
    	Camera.mainCamera.transform.Translate(Vector3(0, 1, 0) * Time.deltaTime * walkspeed);
	}
    if (Input.GetKey("down"))//move down
    {
    	transform.Translate(Vector3(0, 0, - 1) * Time.deltaTime * walkspeed);
    	Camera.mainCamera.transform.Translate(Vector3(0, -1, 0) * Time.deltaTime * walkspeed);
	}
    if (Input.GetKey("left"))//move left
    {
    	transform.Translate(Vector3(-1, 0, 0) * Time.deltaTime * walkspeed);
    	Camera.mainCamera.transform.Translate(Vector3(-1, 0, 0) * Time.deltaTime * walkspeed);
	}
    if (Input.GetKey("right"))//move right
    {
    	transform.Translate(Vector3(1, 0, 0) * Time.deltaTime * walkspeed);
    	Camera.mainCamera.transform.Translate(Vector3(1, 0, 0) * Time.deltaTime * walkspeed);
	}
	
	
}