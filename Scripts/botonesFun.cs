using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class botonesFun : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void stats(){
		SceneManager.LoadScene("Stats");
	}

    public void config() {
        Debug.Log("Configuraciones");
    }

    public void jugar() {
        Debug.Log("Jugar");
        SceneManager.LoadScene("Mapa");
    }
}
