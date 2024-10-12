using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class boll : MonoBehaviour
    {
        public enum Color { RED, BLACK ,BLUE }
        public float Speed = 5.0f;
        public Color color;

        private void Start()
        {
            SetSpeedByColor();
        }

        private void Update()
        {
            //transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }

        public void SetSpeedByColor()
        {
            switch (color)
            {
                case Color.RED:
                    Speed *=2;
                    break;
                case Color.BLACK:
                    Speed *= 1;
                    break;
                case Color.BLUE:
                    Speed *= 1.5f;
                    break;
            }    
        }


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Player"))
            {
                Player m_player = collision.gameObject.GetComponent<Player>();
                m_player.currentHealth -= 1;
      
                if(m_player.currentHealth <= 0)
                    collision.gameObject.SetActive(false);
            }

            if(collision.collider.CompareTag("NonDisable"))
            {
                Destroy(gameObject);
            }
        }
    }
}
