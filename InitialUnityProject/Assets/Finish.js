﻿#pragma strict
private var enter : boolean;

function OnGUI(){
if(enter){
GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "You Won!!!");
//Application.LoadLevel("main scene");
}
}

//Activate the Main function when player is near the door
function OnTriggerEnter (other : Collider){
if (other.gameObject.tag == "Player") {
enter = true;
}
}

//Deactivate the Main function when player is go away from door
function OnTriggerExit (other : Collider){
if (other.gameObject.tag == "Player") {
enter = false;
}
}