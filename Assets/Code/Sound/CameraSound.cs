using UnityEngine;
using System.Collections;

public class CameraSound : MonoBehaviour
{
	public AudioSource sourceMor;
	public AudioSource sourceDar;

	public GameManagerLinght GameManagerLinght;

	// Update is called once per frame
	void Update()
	{
		if(GameManagerLinght.dark == true)
		{
			sourceDar.mute = false;
			sourceMor.mute = true;
		}
		else
		{
			sourceMor.mute = false;
			sourceDar.mute = true;
		}
	}
}

