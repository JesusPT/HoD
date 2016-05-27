using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MENUINICIO : MonoBehaviour {
	void OnGUI(){
		if(GUI.Button(new Rect(500,300,100,50),"INICIO")){
			//Application.LoadLevel("escena1");
			SceneManager.LoadScene("escena1");
		}
	}
}
