using UnityEngine;
using System.Collections;

public class Vectores : MonoBehaviour {

    public float velocidad = 5f;
    Vector3 movimiento;
    Rigidbody player2Rigidbody;

    void Awake()
    {
        player2Rigidbody = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Mover(h,v);
    }	
    
    // Update is called once per frame
	void Update () {
	
	}

    void Mover(float h, float v)
    {
        movimiento = new Vector3(h, 0, v);
        movimiento = movimiento.normalized * velocidad * Time.deltaTime;
        player2Rigidbody.MovePosition(transform.position+movimiento);
    }
}
