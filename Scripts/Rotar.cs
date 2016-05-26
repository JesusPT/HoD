using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour {
    Vector3 velocidadRotacion = new Vector3(0,150,0);
    Quaternion rotacionDelta;
    Rigidbody playerRigidbody;
    //GameObject cubo;   <---segundo método

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () {
        //cubo = GameObject.Find("Cube");	 <---segundo método
    }

    // Update is called once per frame
    void Update () {
	
	}
    //When physics is used
    void FixedUpdate()
    {
        Rotacion();
    }

    void Rotacion()
    {
        //transform.Rotate(0,150*Time.deltaTime,0);  <---segundo método
        rotacionDelta = Quaternion.Euler(velocidadRotacion*Time.deltaTime);
        playerRigidbody.MoveRotation(GetComponent<Rigidbody>().rotation*rotacionDelta);
    }
}
