# Audio_Controller_Example
The Audio Management System from a small project I worked on.
<br>
ROTA by Erich Kohlweg.
<br>
Originally made in untiy 4.6
<br>
<h1>How This Works</h1>
There are 3 audio classes.

1. SFX Master - https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/SFXMaster.cs
<br>
The SFX Master handles all the SFX in the game, it is a prefab that has one audio source and it assigns the right clip before playing it.

2. UI_Audio - https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/UI_Audio.cs
<br>
UI_Audio Handles all the UI audio. This was a Untiy 4.6 apprach.

3. Mixer - https://github.com/DaniKog/Audio_Controller_Example/blob/master/Assets/Scripts/Audio/Mixer.cs
<br>
Mixer class is an improvised mixer,  a list of floats that save the volumes of each SFX and changes the voliune of the sound source before playing the sound. Again
Link to the Game: http://gamejolt.com/games/rota/46815
