using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Managers
{
    public class AudioManager : MonoBehaviour
    {
        [Header("Audio")]
        [SerializeField] private AudioClip _audioClip;
        [SerializeField] private AudioSource _audioSource;


        public void PlayAudio()
        {
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}

