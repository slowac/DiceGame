using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class RandomSound : MonoBehaviour
{
    public static RandomSound Singleton;
    public AudioSource source;
    public AudioClip[] audioClips;
    public Button Button1; // Unity Editor üzerinden atanacak
    public Button Button2;

    void Start()
    {
        gameObject.AddComponent<AudioListener>();

        // Butonun týklama olayýna metod baðla
        if (Button1 != null)
        {
            Button1.onClick.AddListener(PlayRandomSoundOnClick);
        }

        if (Button2 != null)
        {
            Button2.onClick.AddListener(PlayRandomSoundOnClick);
        }
    }

    private void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void PlayRandomSoundOnClick()
    {
        if (audioClips.Length > 0)
        {
            AudioClip randomClip = audioClips[UnityEngine.Random.Range(0, audioClips.Length)];
            SetSourceClip(randomClip);
        }
    }

    public void SetSourceClip(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
}