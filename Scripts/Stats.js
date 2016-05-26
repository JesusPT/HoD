#pragma strict
var salud = 100;
var ataque = 100;
var defensa = 100;
var velocidad = 100;
var xpoints = 10;
var miGUI:GUISkin;
function Start () {

}

function Update () {

}
function OnGUI(){

	if(miGUI){
		GUI.skin = miGUI;
	}
	
	GUI.Box(Rect(Screen.width/2-200,Screen.height/2-200,400,400),"Stats");
	//Salud
	GUI.Label(Rect(Screen.width/2-110,Screen.height/2-100,200,30),"Salud       "+salud);
	if(GUI.Button(Rect(Screen.width/2+70,Screen.height/2-100,20,20),"+")){
	if(xpoints>0){
		xpoints--;
		salud++;
		}
	}
	//Ataque
	GUI.Label(Rect(Screen.width/2-110,Screen.height/2-70,200,30),"Ataque     "+ataque);
	if(GUI.Button(Rect(Screen.width/2+70,Screen.height/2-70,20,20),"+")){
		if(xpoints>0){
		xpoints--;
		ataque++;
		}
	}
	//Defensa 
	GUI.Label(Rect(Screen.width/2-110,Screen.height/2-40,200,30),"Defensa   "+defensa);
	if(GUI.Button(Rect(Screen.width/2+70,Screen.height/2-40,20,20),"+")){
		if(xpoints>0){
		xpoints--;
		defensa++;
		}
	}
	//Velocidad
	GUI.Label(Rect(Screen.width/2-110,Screen.height/2-10,200,30),"Velocidad "+velocidad);
	if(GUI.Button(Rect(Screen.width/2+70,Screen.height/2-10,20,20),"+")){
		if(xpoints>0){
		xpoints--;
		velocidad++;
		}
	}
	//Puntos de experiencia
	GUI.Label(Rect(Screen.width/2-110,Screen.height-200,200,40),"Puntos de experiencia: "+xpoints);
}