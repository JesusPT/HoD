var target : Transform; //the enemy's target
var moveSpeed = 3; //move speed
var rotationSpeed = 3; //speed of turning
var other : Transform;


var myTransform : Transform; //current transform data of this enemy


function Awake()
{
    myTransform = transform; //cache transform data for easy access/preformance
}


function Start()
{
     target = GameObject.FindWithTag("Player").transform; //target the player


}


function Update () {
    //rotate to look at the player
    myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
    Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);


 	//move towards the player
 	myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

 	
	if (other) {
		var dist = Vector3.Distance(other.position, transform.position);
		//Debug.Log("Distance to other: " + dist);
		if (dist<15) {
			GetComponent.<Animation>().Play("orcattack");
			Do();
		}
	}
}
function Do(){
	yield WaitForSeconds(3);
	GetComponent.<Animation>().Play("orcwalk");
}

