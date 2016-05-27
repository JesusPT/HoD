using UnityEngine;
using System.Collections;

public class Inventario : MonoBehaviour {
    string[] frutas = {"arandanos","peras","manzanas","limones","sandias","fresas" };
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log(frutas[0]);
        }
        if (Input.GetKeyDown("b"))
        {
            Debug.Log(frutas[1]);
        }
        if (Input.GetKeyDown("c"))
        {
            Debug.Log(frutas[2]);
        }
        if (Input.GetKeyDown("d"))
        {
            Debug.Log(frutas[3]);
        }
        if (Input.GetKeyDown("e"))
        {
            Debug.Log(frutas[4]);
        }
        if (Input.GetKeyDown("f"))
        {
            Debug.Log(frutas[5]);
        }
    }
}
