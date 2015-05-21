

function OnMouseEnter()
{
GetComponent.<Renderer>().material.color = Color.grey;
GetComponent.<AudioSource>().Play();
}

function OnMouseExit()
{
GetComponent.<Renderer>().material.color = Color.white;
}