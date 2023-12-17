using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CategoryBtnScript : MonoBehaviour
{
    [SerializeField] private Text categoryTitleText;
    [SerializeField] private Text scoreText;
    [SerializeField] private Button btn;
    //audio joe
    [SerializeField] private AudioClip buttonAudioClip;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject audioHolder;



    public Button Btn { get => btn; }

    public void SetButton(string title, int totalQuestion)
    {
        categoryTitleText.text = title;
        scoreText.text = PlayerPrefs.GetInt(title, 0) + "/" + totalQuestion; //we get the score save for this category
    }

    // audio joe
    public void PlayButtonAudio()
    {
        if (buttonAudioClip != null && audioHolder != null)
        {
            AudioSource audioSource = audioHolder.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.PlayOneShot(buttonAudioClip);
            }
        }
    }

    private void Awake()
    {
        if (btn != null)
        {
            btn.onClick.AddListener(PlayButtonAudio);
        }
    }


}
