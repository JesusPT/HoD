using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {
    public GameObject explosion,exp1,exp2,exp3,exp4;
    string letrero = "          ";
    public AudioClip clip;
    int cont = 0;
	//Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision golpe)
    {

        if (golpe.transform.name=="Enemigo" )
        {
            Destroy(Instantiate(explosion, transform.position, transform.rotation),2f);
            letrero = "Has eliminado ";
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            cont++;
        } 
		if (golpe.transform.name=="En1" )
		{
			Destroy(Instantiate(exp1, transform.position, transform.rotation),2f);
			letrero = "Has eliminado ";
			AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
			cont++;
		} 
		if (golpe.transform.name=="En2" )
		{
			Destroy(Instantiate(exp2, transform.position, transform.rotation),2f);
			letrero = "Has eliminado ";
			AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
			cont++;
		} 
		if (golpe.transform.name=="En3" )
		{
			Destroy(Instantiate(exp3, transform.position, transform.rotation),2f);
			letrero = "Has eliminado ";
			AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
			cont++;
		} 
		if (golpe.transform.name=="En4" )
		{
			Destroy(Instantiate(exp4, transform.position, transform.rotation),2f);
			letrero = "Has eliminado ";
			AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
			cont++;
		} 
        //Instantiate (explosion, transform.position,transform.rotation);
    }
    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 150, 100), letrero+cont+" cubos");
    }
}
