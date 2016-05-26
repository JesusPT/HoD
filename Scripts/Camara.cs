using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3f;

	private Vector3 velocity = Vector3.zero;

	void Update () {
		Camera.main.fieldOfView = 12;
		Vector3 goalPos = target.position;
		goalPos.y = transform.position.y;
		goalPos.x = target.position.x - 70;
		goalPos.z = target.position.z -350;
		transform.position = Vector3.SmoothDamp (transform.position, goalPos, ref velocity, smoothTime);
	}
}