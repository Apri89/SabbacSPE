#pragma strict
static var doorBroken;
function Start() {
	doorBroken=false;
}
function OnJointBreak(breakForce : float) { 
	doorBroken = true;
}