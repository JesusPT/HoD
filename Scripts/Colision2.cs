using UnityEngine;
using System.Collections;

public class Colision2 : MonoBehaviour {
	public GameObject explosion;
	public AudioClip clip;
	//Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision golpe)
	{

		if (golpe.transform.name=="Enemiguillo" )
		{
			Destroy(Instantiate(explosion, transform.position, transform.rotation),2f);
			AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
		} 

		//Instantiate (explosion, transform.position,transform.rotation);
	}

}
