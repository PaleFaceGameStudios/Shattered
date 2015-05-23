var quit = false;

function OnMouseEnter()
{
 GetComponent.<Renderer>().materal.color = Color.red;
}

function OnMouseExit()
{
 GetComponent.<Renderer>().materal.color = Color.white;
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
