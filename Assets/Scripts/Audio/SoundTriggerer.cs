using UnityEngine;
using System.Collections;

public class SoundTriggerer : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
		{
			SFXMaster.Instance.PlaySFX(SFXMaster.SFXClip.Shoot);
		}
		if(Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
		{
			SFXMaster.Instance.PlaySFX(SFXMaster.SFXClip.OrbDeath);
		}
		if(Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
		{
			SFXMaster.Instance.PlaySFX(SFXMaster.SFXClip.WallBounce);
		}
		if(Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
		{
			SFXMaster.Instance.PlaySFX(SFXMaster.SFXClip.SpikeExplode);
		}
		if(Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
		{
			SFXMaster.Instance.PlaySFX(SFXMaster.SFXClip.YouWin);
		}
	}

		public void PlayForward()
		{
			UI_Audio.Instance.PlayUI (UI_Audio.UIClip.Forward);
		}
		public void PlayBackwards()
		{
			UI_Audio.Instance.PlayUI (UI_Audio.UIClip.Backwards);
		}
		public void PlayRestart()
		{
			UI_Audio.Instance.PlayUI (UI_Audio.UIClip.Restart);
		}
		public void NextSence()
		{
			Application.LoadLevel (1);
		}
		public void PreviousSence()
		{
			Application.LoadLevel (0);
		}
}
