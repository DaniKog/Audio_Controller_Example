using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class UI_Audio : Singleton<UI_Audio>
{
	//Open Varables for UI SFX
	public AudioClip ui_Forward;
	public AudioClip ui_Backwards;
	public AudioClip ui_Restart;
	//an Enum for easy call for the play function
	public enum UIClip 
	{
		Forward ,
		Backwards,
		Restart
	}
		// Use this for initialization
		void Start ()
		{
			DontDestroyOnLoad (gameObject);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

	//UI play func, get 1 parameter that will determen which sound will play
	public void PlayUI(UIClip ui_Clip)
	{
		switch (ui_Clip) 
		{
		
			case UIClip.Forward:
			GetComponent<AudioSource>().volume = Mixer.Instance.vol_ui_Forward;
				GetComponent<AudioSource>().PlayOneShot(ui_Forward);
			break;

		case UIClip.Backwards:
			GetComponent<AudioSource>().volume = Mixer.Instance.vol_ui_Backwards;
			GetComponent<AudioSource>().PlayOneShot(ui_Backwards);
			break;

		case UIClip.Restart:
			GetComponent<AudioSource>().volume = Mixer.Instance.vol_ui_Restart;
			GetComponent<AudioSource>().PlayOneShot(ui_Restart);
			break;

		default:
			GetComponent<AudioSource>().volume = Mixer.Instance.vol_ui_Forward;
			GetComponent<AudioSource>().PlayOneShot(ui_Forward);
			break;
		}
	}
}

