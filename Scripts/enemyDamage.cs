using System.Collections;
using UnityEngine;

public class enemyDamage : MonoBehaviour{
	public int enemyHealth = 50;
	public int TheDamage = 10;
		
	public void Ouch (){
		enemyHealth -= TheDamage;
		StartCoroutine (Damage ());
		print ("Vida: "+enemyHealth);
		if(enemyHealth<=0){
		
			StartCoroutine (Die ());
		}

		}
	void imDead(){



	}
	IEnumerator Die() {
		GetComponent<Animation>().Play("orcdie");
		yield return new WaitForSeconds(2); //this will wait 5 seconds
		Destroy (gameObject);
	}
	IEnumerator Damage() {
		GetComponent<Animation>().Play("orcdamage");
		yield return new WaitForSeconds(2); //this will wait 5 seconds
		GetComponent<Animation>().Stop("orcdamage");
	}

}

