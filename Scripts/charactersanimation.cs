using UnityEngine;
using System.Collections;

public class charactersanimation : MonoBehaviour {
	void orcdie(){
		GetComponent<Animation>().Play("orcdie");
	}
	public void orcdamage(){
		GetComponent<Animation>().Play("orcdamage");
	}
}
