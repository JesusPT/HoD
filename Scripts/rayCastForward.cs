using UnityEngine;
using System.Collections;

public class rayCastForward : MonoBehaviour {
	public enemyDamage _enemyDamage;
	public float TheDistance;
	public float maxDistance;
	// Update is called once per frame

		void Update(){
		if(Input.GetButtonDown("Fire1")){
			//print ("Feuer!");
			RaycastHit hit;

			Vector3 forward = transform.TransformDirection(Vector3.forward) * 20;
			Debug.DrawRay (transform.position,forward,Color.green);

		if (Physics.Raycast (transform.position, (forward), out hit))
			TheDistance = hit.distance;
			print(TheDistance + " " + hit.collider.gameObject.name);

			if(TheDistance<maxDistance){
				_enemyDamage.Ouch ();

			}
			}
		}
	}

