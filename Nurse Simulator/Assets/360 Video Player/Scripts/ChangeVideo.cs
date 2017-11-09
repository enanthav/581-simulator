using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class ChangeVideo : MonoBehaviour {
	GameObject[] assessmentObjects;
	public VideoPlayer videoPlayer;
	public VideoClip[] videos = new VideoClip[5];

	void Start () {
		assessmentObjects = GameObject.FindGameObjectsWithTag ("ShowOnAssess");
	}

	// Update is called once per frame
	void Update () {

	}

	public void PlayRounding () {
		SwitchVideo (1);
	}

	// AGGRESSIVE VIDEO
	public void PlayAggressive () { 
		SwitchVideo (2);
	}
	// OPTIONS FOR AGGRESSIVE VIDEO
	public void PlayAggressiveDistraction () {
		SwitchVideo (3);
	}

	public void PlayEndOfShift () {
		SwitchVideo (4);
	}

	public void PlayAssessment () {
		SwitchVideo (5);
	}

	public void SwitchVideo(int index)
	{
		videoPlayer.clip = videos[index];
		videoPlayer.Play();
	}
}