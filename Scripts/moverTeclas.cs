using UnityEngine;
using System.Collections;

public class moverTeclas : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            transform.Translate(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * 70);
            GetComponent<Animation>().Play("run");
        }else {
            GetComponent<Animation>().Play("idlebattle");
        }

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.Rotate(0, Input.GetAxisRaw("Horizontal") * Time.deltaTime * 150, 0);
            
        }

        if (Input.GetMouseButton(0)) {
            GetComponent<Animation>().Play("attack");
        }
        

    }
}
