using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSelector : MonoBehaviour
{

    private AudioSource soundSource;
    public AudioClip[] audioClips;

	// Use this for initialization
	void Start ()
    {
        soundSource = (AudioSource)GetComponent(typeof(AudioSource));
	}

    private void OnTriggerEnter(Collider collider)
    {
        AudioClip randomClip = audioClips[Random.Range(0, audioClips.Length)];
        soundSource.clip = randomClip;
        soundSource.Play();

        Debug.Log("IS hitting cube");
    }

    private void OnTriggerExit(Collider collider)
    {
        soundSource.Stop();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
