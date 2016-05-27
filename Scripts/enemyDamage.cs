using System.Collections;
using UnityEngine;

public class enemyDamage : MonoBehaviour{

	int enemyHealth = 50;
	int TheDamage = 10;
		
	public void Ouch (){
		enemyHealth -= TheDamage;
		print ("Vida: "+enemyHealth);
		if(enemyHealth<=0){
			imDead ();
		}

		}
	void imDead(){
		Destroy (gameObject);
	}
}

