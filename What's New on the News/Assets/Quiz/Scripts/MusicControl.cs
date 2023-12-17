using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    public Image buttonImage;
    public Sprite musicPlayingSprite;
    public Sprite musicMutedSprite;

    private bool isMuted = false;
    private AudioManager audioManager; // Add this reference

    private void Start()
    {
        // Find the AudioManager in the scene
        audioManager = FindObjectOfType<AudioManager>();
        UpdateButtonSprite();
    }

    public void ToggleMusic()
    {
        if (isMuted)
        {
            audioManager.PlayMusic();
        }
        else
        {
            audioManager.StopMusic();
        }

        isMuted = !isMuted;
        UpdateButtonSprite();
    }

    private void UpdateButtonSprite()
    {
        buttonImage.sprite = isMuted ? musicMutedSprite : musicPlayingSprite;
    }
}
