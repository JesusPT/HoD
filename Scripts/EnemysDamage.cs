using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using SceneManagement;

public class EnemysDamage : MonoBehaviour {

	public Scrollbar HealthBar;
	public float Health = 100;

	
	void Update(){
		if(Health<=0){

		}
	}

	void OnCollisionEnter(Collision golpe){
	  	if (golpe.transform.name=="SpartanKing" )
        {
            //Destroy(Instantiate(explosion, transform.position, transform.rotation),2f);
            //print("madrazo");
            Damage(10f);
            
        } 
	  }



	public void Damage(float value){
		Health -= value;
		HealthBar.size = Health / 100f;
	}


	public void pocion(){

	}


}