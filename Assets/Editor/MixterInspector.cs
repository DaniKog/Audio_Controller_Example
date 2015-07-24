using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Mixer))]
public class MixterInspector : Editor
{
	//Visable Mixing Deck
	public override void OnInspectorGUI()
	{
		Mixer mymixerScript = (Mixer)target;

		mymixerScript.vol_shoot = EditorGUILayout.Slider ("Shoot",mymixerScript.vol_shoot,0f,1f);
		mymixerScript.vol_orbDeath = EditorGUILayout.Slider ("Orb Death",mymixerScript.vol_orbDeath,0f,1f);
		mymixerScript.vol_wallBounce = EditorGUILayout.Slider ("Wall Bounce",mymixerScript.vol_wallBounce,0f,1f);
		mymixerScript.vol_spikeExplode = EditorGUILayout.Slider ("Spike Explode",mymixerScript.vol_spikeExplode,0f,1f);
		mymixerScript.vol_youWin = EditorGUILayout.Slider ("You Win",mymixerScript.vol_youWin,0f,1f);
		EditorGUILayout.LabelField ("----------------UI----------------");
		mymixerScript.vol_ui_Backwards = EditorGUILayout.Slider ("Backwards", mymixerScript.vol_ui_Backwards, 0f, 1f);
		mymixerScript.vol_ui_Forward = EditorGUILayout.Slider ("Forward",mymixerScript.vol_ui_Forward,0f,1f);
		mymixerScript.vol_ui_Restart = EditorGUILayout.Slider ("Restart",mymixerScript.vol_ui_Restart,0f,1f);
		EditorGUILayout.LabelField ("----------------Music----------------");
		mymixerScript.vol_Music = EditorGUILayout.Slider ("Music",mymixerScript.vol_Music,0f,1f);
		EditorGUILayout.LabelField ("Unity 4 Native Audio...Sucked....");
		if(GUI.changed)
		{
			//Saves the Values of the mixer to the HD
			EditorUtility.SetDirty (target);
		}

	}
	void OnDestroy()
	{

	}
}
