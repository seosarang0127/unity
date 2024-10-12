using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Classstudy
{
    public class PlayerUI : MonoBehaviour
    {
        public Player player;
        public Image[] images;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < player.maxHealth; i++)
            {
                images[i].gameObject.SetActive(false);
            }

            for (int i=0; i<player.currentHealth; i++)
            {
                images[i].gameObject.SetActive(true);
            }

        }
    }
}
