using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioClip[] footstepSounds; // Array to hold footstep sound clips
    public float minTimeBetweenFootsteps = 0.6f; // Minimum time between footstep sounds
    public float maxTimeBetweenFootsteps = 0.6f; // Maximum time between footstep sounds

    private AudioSource audioSource; // Reference to the Audio Source component
    private bool isWalking = false; // Flag to track if the player is walking
    private float timeSinceLastFootstep; // Time since the last footstep sound
    private AudioClip lastFootstepSound; // Last footstep sound that was played

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>(); // Get the Audio Source component
    }

    private void Update()
    {
        // Check if the player is walking
        if (isWalking)
        {
            // Check if enough time has passed to play the next footstep sound
            if (Time.time - timeSinceLastFootstep >= Random.Range(minTimeBetweenFootsteps, maxTimeBetweenFootsteps))
            {
                // Play a random footstep sound from the array (ensure it's not the same as the last one)
                AudioClip footstepSound = GetRandomFootstepSound();
                audioSource.PlayOneShot(footstepSound);

                timeSinceLastFootstep = Time.time; // Update the time since the last footstep sound
                lastFootstepSound = footstepSound; // Update the last footstep sound
            }
        }
    }

    // Call this method when the player starts walking
    public void StartWalking()
    {
        isWalking = true;
    }

    // Call this method when the player stops walking
    public void StopWalking()
    {
        isWalking = false;
    }

    // Get a random footstep sound from the array, ensuring it's not the same as the last one
    private AudioClip GetRandomFootstepSound()
    {
        if (footstepSounds.Length == 0)
        {
            Debug.LogWarning("No footstep sounds assigned.");
            return null;
        }

        if (footstepSounds.Length == 1)
        {
            return footstepSounds[0];
        }

        AudioClip randomSound;
        do
        {
            randomSound = footstepSounds[Random.Range(0, footstepSounds.Length)];
        } while (randomSound == lastFootstepSound);

        return randomSound;
    }
}
