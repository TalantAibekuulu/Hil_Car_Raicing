using System;
using System.Collections.Generic;
using UnityEngine;
namespace Services

{
    public class AudioService : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioPlayer;
        [SerializeField] private List<AudioClass> _audioClips;
        public void PlayuAudio(string audioName)
        {
            AudioClip audioClip = null;
            foreach (AudioClass clip in _audioClips)
            {
                if (clip.name == audioName)
                {
                    audioClip = clip.audio;

                    break;

                }

            }
            _audioPlayer.clip = audioClip;
            _audioPlayer.Play();

        }
    }

    [Serializable]
    public class AudioClass
    {
        public string name;
        public AudioClip audio;
    }
}
