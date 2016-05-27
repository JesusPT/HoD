using UnityEngine;
using System.Collections;

public class monExp : MonoBehaviour {
    public int Exp;
    public int Mon;
	// Use this for initialization
	void Start () {
        Exp = 0;
        Mon = 0;
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void masExp(int c) {
        Exp += c;
    }

    void masMon(int c)
    {
        Mon += c;
    }
}
