using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoUIController : MonoBehaviour {

    public VideoPlayer playerToControl;

    private AudioSource audioSource;
    private float oldVolume = 1.0f;

    private void Start()
    {
        audioSource= playerToControl.gameObject.GetComponent<AudioSource>();
        oldVolume = audioSource.volume;
    }


    public void TogglePause()
    {
//        if (playerToControl.isPlaying)
//        {
//            playerToControl.Pause();
//        }
//        else
//        {
//            playerToControl.Play();
//        }
		SceneManager.LoadScene("Wandering Scene");
    }


	public void DistractWander()
	{
		SceneManager.LoadScene("Wandering Distract");
	}


	public void CorrectWander()
	{
		SceneManager.LoadScene("Wandering Correct");
	}


    public void ToggleMute()
    {
        if (audioSource.volume > 0.0f)
        {
            oldVolume = audioSource.volume;
            audioSource.volume = 0.0f;
        }
        else
        {
            audioSource.volume = oldVolume;
        }
    }

//	public void PlayNextClip(){
//		// Will attach a VideoPlayer to the main camera.
//		GameObject camera = GameObject.Find("Main Camera");
//
//		// VideoPlayer automatically targets the camera backplane when it is added
//		// to a camera object, no need to change videoPlayer.targetCamera.
//		var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
//
//		// Play on awake defaults to true. Set it to false to avoid the url set
//		// below to auto-start playback since we're in Start().
//		videoPlayer.playOnAwake = false;
//
//		// By default, VideoPlayers added to a camera will use the far plane.
//		// Let's target the near plane instead.
//		videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;
//
//		// This will cause our scene to be visible through the video being played.
//		videoPlayer.targetCameraAlpha = 0.5F;
//
//		// Set the video to play. URL supports local absolute or relative paths.
//		// Here, using absolute.
//		videoPlayer.url = "/Users/elizabeth/Documents/CPSC 581/Nurse Simulator/Assets/360 Video Player/Videos/london.mp4";
//		videoPlayer.Play();
//	}
}
