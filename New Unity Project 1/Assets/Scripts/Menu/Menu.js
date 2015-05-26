var quit = false;
 var myClip : AudioClip ;

function OnMouseEnter()
{
GetComponent.<AudioSource>().Play();
}

function OnMouseExit()
{
}

function OnMouseUp(){
if(quit == true){
	Application.Quit();
}
else{
Application.LoadLevel(1);
}
}
function Update(){

if(Input.GetKey(KeyCode.Escape)){
Application.Quit();
}

}
