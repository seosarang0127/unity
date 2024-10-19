using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class PlayerMove : MonoBehaviour
    {
        public float speed = 5f;  // �÷��̾ �̵��� �ӷ�

        
        // Update is called once per frame
        void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(h, v, 0);

            transform.position = transform.position + dir * speed * Time.deltaTime;
        }
    }
}
