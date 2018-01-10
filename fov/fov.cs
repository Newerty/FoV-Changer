/* 
To zrobilem ja - Rafał
*/



function fov_dodaj()
{
	if ($Pref::player::CurrentFOV < 120 )
	{
		%fov = $Pref::player::CurrentFOV + 1;
		$Pref::player::CurrentFOV = %fov;
		setDefaultFov(%fov);
		cmChat_onServerMessage(%fov);
	}
}

function fov_odejmij()
{
	if ($Pref::player::CurrentFOV > 40 )
	{
		%fov = $Pref::player::CurrentFOV - 1;
		$Pref::player::CurrentFOV = %fov;
		setDefaultFov(%fov);
		cmChat_onServerMessage(%fov);
	}
}

function fov_zoom()
{
	%fov = $Pref::player::CurrentFOV;
	%a++;
	setDefaultFov(35);
	
	if (%a = 2)
	{
		setDefaultFov(%fov);
	}
}

//klawisze
moveMap.bindCmd(keyboard,"=","fov_dodaj();");
moveMap.bindCmd(keyboard,"-","fov_odejmij();");
moveMap.bindCmd(mouse, "button2","fov_zoom();");