using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    private static AudioManager instance;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayMusic();
    }

    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject); // This line ensures the AudioManager persists
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
