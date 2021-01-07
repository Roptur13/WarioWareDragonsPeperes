using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Dragons_Peperes
{
    namespace CestNotreTresor
    {
        /// <summary>
        /// Mael Ricou
        /// </summary>
        public class AudioManager : MonoBehaviour
        {
            private AudioSource[] sounds;

            private AudioSource running;
            private AudioSource ambiance;
            private AudioSource catched;

            private void Start()
            {
                sounds = GetComponents<AudioSource>();

                running = sounds[0];
                ambiance = sounds[1];
                catched = sounds[2];
                
                
            }

            #region Functions pour lancer les sons
            public void PlayRunning()
            {
                running.Play();
            }

            public void PlayAmbiance()
            {
                ambiance.Play();
            }

            public void PlayCatched()
            {
                catched.Play();
            }
            #endregion

            #region Functions pour arreter les sons
            public void StopRunning()
            {
                running.Stop();
            }

            public void StopAmbiance()
            {
                ambiance.Stop();
            }

            public void StopCatched()
            {
                catched.Stop();
            }
            #endregion
        }
    }
}
