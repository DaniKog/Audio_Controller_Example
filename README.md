# Audio_Controller_Example
The Audio Management System from a small project I worked on called ROTA.
<br>
ROTA by Erich Kohlweg: http://gamejolt.com/games/rota/46815
<br>
Originally made in untiy 4.6
<br>
Recompiled for Untiy 5.1
<h1>How This Works</h1>
The Audio for the game is handled with 2 sound sources and 4 Audio Classes

<h3>1. SFX Master</h3>
https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/SFXMaster.cs
<br>
The SFX Master handles all the SFX in the game, it is a prefab that has one audio source and it assigns the right clip before playing it.

<h3>2. UI_Audio </h3>
https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/UI_Audio.cs
<br>
Ths class handles all the UI audio. This prefab has a sound source as well, it plays UI sounds when needed.

<h3>3. Mixer</h3>
https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/Mixer.cs
<br>
Mixer class is an improvised mixer,  a list of floats that save the volumes of each SFX and changes the voliune of the sound source before playing the sound.
<br>
<h3> 4. Audio Manager  </h3>
https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/AudioManager.cs
<br>
The instance of this class only exists on the main menu. It checks if the other classes exist in the scnene and creates them from resources if they don't.
