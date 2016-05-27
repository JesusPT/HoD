using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class parpadeo2 : MonoBehaviour {

    public Text t;
    public Color c;
    bool b = true;
	// Use this for initialization
	void Start () {
        c.a = 1;
        t.color = c;
	}
	
	// Update is called once per frame
	void Update () {
        if (b) {
            c.a -= Time.deltaTime;
        }
        else {
            c.a += Time.deltaTime;
        }

        if (c.a < 0) {
            c.a = 0;
            b = false;
        }

        if (c.a > 1)
        {
            c.a = 1;
            b = true;
        }
        t.color = c;
    }
}
