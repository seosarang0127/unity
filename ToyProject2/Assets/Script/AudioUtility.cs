using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class AudioUtility : MonoBehaviour
    {
        public AudioSource audioSource;

        // Start is called before the first frame update
        void Start()
        {
            float randomPitch = Random.Range(0.5f, 1.0f);
            audioSource.pitch = randomPitch;

        }
    }
}
