using UnityEngine;
using System.Collections;
using System;
using System.Linq;
using System.Collections.Generic;



public class AudioManager : MonoBehaviour 
{
	private Mixer mixer;

	private SFXMaster sfxMaster;

	private UI_Audio uiAudio;

	void Awake ()
		{
			FindObject<Mixer>(ref mixer, true, false);
			FindObject<SFXMaster>(ref sfxMaster, true, false);
			FindObject<UI_Audio>(ref uiAudio, true, false);
		}

		private void FindObject<T> (ref T storage, bool createOnDemand = false, bool parentToGameObject = false) where T : MonoBehaviour
		{
			// Casting
			UnityEngine.Object obj = FindObjectOfType (typeof(T));
			storage = (T)Convert.ChangeType (obj, typeof(T));
	
			// Assert
			if(storage == null)
			{
				Debug.LogWarning ("There is no instance of " + typeof(T).ToString() + " on the scene, make sure there's at least one ");
				if(createOnDemand)
				{
					Debug.LogWarning("Creating object from the resources folder...");
					
					storage = ((GameObject)Instantiate(Resources.Load(typeof(T).ToString()))).GetComponent<T>();
					if(storage == null)
					{
						Debug.LogError("Could not find object " + typeof(T) + " on resources.");
						return;
					}
					
					if(parentToGameObject)
						storage.transform.parent = transform;
				}
			}
		}
		
	}

