using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ChangeVideo : MonoBehaviour {
	GameObject[] assessmentObjects;
	public VideoPlayer videoPlayer;
	public VideoClip[] videos = new VideoClip[5];

	void Start () {
//		assessmentObjects = GameObject.FindGameObjectsWithTag ("ShowOnAssess");
	}

	// Update is called once per frame
	void Update () {

	}

	public void PlayAssessment () {
		SceneManager.LoadScene ("Assessment");
		//		SwitchVideo (5);
	}


	public void PlayRounding () {
		SceneManager.LoadScene ("Rounding");
//		SwitchVideo (1);
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
//		SwitchVideo (4);
	}



	public void EndOfShift () {
		SceneManager.LoadScene ("End of Shift");
	}

	public void SwitchVideo(int index)
	{
		videoPlayer.clip = videos[index];
		videoPlayer.Play();
	}
}