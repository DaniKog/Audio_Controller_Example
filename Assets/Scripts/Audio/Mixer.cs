using UnityEngine;
using System.Collections;

public class Mixer : Singleton<Mixer>
{
	public float vol_shoot ;
	public float vol_orbDeath ;
	public float vol_wallBounce ;
	public float vol_spikeExplode ;
	public float vol_youWin ;

	public float vol_ui_Forward ;
	public float vol_ui_Backwards ;
	public float vol_ui_Restart ;

	public float vol_Music ;
		// Use this for initialization
		void Start ()
		{
			DontDestroyOnLoad (gameObject);
		}
	
		// Update is called once per frame
		void Update ()
		{
			
		}
}
