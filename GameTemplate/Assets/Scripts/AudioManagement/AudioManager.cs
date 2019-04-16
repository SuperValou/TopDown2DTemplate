using System;
using Assets.Scripts.Utilities;
using UnityEngine;

namespace Assets.Scripts.AudioManagement
{
    public class AudioManager : MonoBehaviour
    {
        public AudioClip[] musicTracks;
        public AudioClip[] soundEffects;

        private AudioSource _source;

        void Start()
        {
            _source = this.GetComponentOrThrow<AudioSource>();
        }

        public void PlayMusic(MusicTrack musicTrack)
        {
            int musicTrackCode = (int) musicTrack;
            if (musicTrackCode < 0 || musicTrackCode >= musicTracks.Length)
            {
                throw new ArgumentException($"{nameof(AudioManager)} was required to play music track {musicTrackCode} ({musicTrack}) " +
                                            $"but there is only {musicTracks.Length} tracks available.");
            }

            _source.clip = musicTracks[musicTrackCode];
            _source.Play();
        }

        public void StopMusic()
        {
            _source.Stop();
        }

        public void PlaySound(SoundEffect soundEffect)
        {
            int soundCode = (int)soundEffect;
            if (soundCode < 0 || soundCode >= soundEffects.Length)
            {
                throw new ArgumentException($"{nameof(AudioManager)} was required to play sound effect {soundCode} ({soundCode}) " +
                                            $"but there is only {soundEffects.Length} sounds available.");
            }

            var clip = soundEffects[soundCode];
            _source.PlayOneShot(clip);
        }
    }
}