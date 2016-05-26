#pragma strict

var TheDammage : int = 100;
var Distance : float ;
var MaxDistance : float = 3.0;
function Start () {

}

function Update () {
    if(Input.GetKey(KeyCode.Space)){
        var hit : RaycastHit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),hit)) {
            Distance = hit.distance;
            if(Distance<MaxDistance){
                 hit.collider.SendMessageUpwards ("ApplyDammage", TheDammage, SendMessageOptions.DontRequireReceiver);
        }   
     }  
    }

}