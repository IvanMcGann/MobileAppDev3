using System;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;     // Store the name of our music/effect
    public AudioClip clip;  // Store music/effect clip
    [Range(0f, 1f)]         // Limit the range in the Unity editor
    public float volume;    // Store volume
    [Range(0.1f, 3f)]       // Limit the Range again
    public float pitch;     // Set the picth for our music/effect
    [HideInInspector]       // Hide this variable from the Editor
    public AudioSource source; // The source that will play audio
    public bool loop = false; // Loop music
}