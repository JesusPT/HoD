var smooth:int;
private var targetPosition:Vector3;
function Start(){

	GetComponent.<Animation>().Play("idle");
} 
function Update () {
	if (Input.GetKeyDown(KeyCode.Mouse1)) {
		GetComponent.<Animation>().Play("attack");
	}
 
    if(Input.GetKeyDown(KeyCode.Mouse0)) {
	GetComponent.<Animation>().Play("run");
 
        smooth=1;
        var playerPlane = new Plane(Vector3.up, transform.position);
        var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        var hitdist = 0.0;
 
        if (playerPlane.Raycast (ray, hitdist)) {
 
            var targetPoint = ray.GetPoint(hitdist);
            targetPosition = ray.GetPoint(hitdist);
            var targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            transform.rotation = targetRotation;
        }
    }
    transform.position = Vector3.Slerp (transform.position, targetPosition, Time.deltaTime * smooth);  
}