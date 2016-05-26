#pragma strict
	//Instantiate a rigidbody then set the velocity
	var projectile : Rigidbody;
	//Instantiate the projectile at the position and rotation


	// Update is called once per frame
	function Update () {
		//Ctrl was pressed, launch a projectile
		if(Input.GetButtonDown("Fire1")){
		var clone : Rigidbody;
			clone = Instantiate(projectile, transform.position, transform.rotation);
			//Give the cloned object an initial velocity along the current object's Z axis
			clone.velocity = transform.TransformDirection(Vector3.left*10);
			Destroy(clone.gameObject,0.7f);
		}
	}