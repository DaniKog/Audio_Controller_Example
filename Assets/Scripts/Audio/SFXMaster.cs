using UnityEngine;
using System.Collections;

public class SFXMaster : Singleton<SFXMaster>
{
	//Open Varables for SFX
	public AudioClip[] shoot;
	public AudioClip[] orbDeath;
	public AudioClip[] wallBounce;
	public AudioClip[] spikeExplode;
	public AudioClip youWin;

	private AudioSource myaudio;
	//an Enum for easy call for the play function

	public enum SFXClip 
	{
		Shoot ,
		OrbDeath,
		WallBounce,
		SpikeExplode,
		YouWin
	}

	//an int in to calculate the lengh of the sound clip arry
	private int clipLength;
	//an int to determin which clip to play
	private int clipToPlay;

	// Use this for initialization
	void Start ()
	{
		DontDestroyOnLoad (gameObject);
		myaudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	public void PlaySFX(SFXClip SFX_Clip)
	{
		switch (SFX_Clip) 
		{
			
		case SFXClip.Shoot:
			clipToPlay = RandomClipPicker(shoot);
			myaudio.volume = Mixer.Instance.vol_shoot;
			myaudio.PlayOneShot(shoot[clipToPlay]);
			break;

		case SFXClip.OrbDeath:
			clipToPlay = RandomClipPicker(orbDeath);
			myaudio.volume = Mixer.Instance.vol_orbDeath;
			myaudio.PlayOneShot(orbDeath[clipToPlay]);
			break;

		case SFXClip.SpikeExplode:
			clipToPlay = RandomClipPicker(spikeExplode);
			myaudio.volume = Mixer.Instance.vol_spikeExplode;
			myaudio.PlayOneShot(spikeExplode[clipToPlay]);
			break;

		case SFXClip.WallBounce:
			clipToPlay = RandomClipPicker(wallBounce);
			myaudio.volume = Mixer.Instance.vol_wallBounce;
			myaudio.PlayOneShot(wallBounce[clipToPlay]);
			break;
		case SFXClip.YouWin:
			myaudio.volume = Mixer.Instance.vol_youWin;
			myaudio.PlayOneShot(youWin);
			break;

		}
	}
	private int RandomClipPicker(AudioClip[] clipArry)
		{
			clipLength = clipArry.Length;
			
			if(clipLength == 0)
			{
				Debug.LogError(clipArry.ToString() + " I don't have any audio clips assign to it");
				return(9999);
			}
			return(Random.Range(0,clipLength));
		}


	
}
