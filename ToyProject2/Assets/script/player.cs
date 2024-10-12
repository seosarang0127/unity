using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class Player : MonoBehaviour
    {
        #region �� ����

        // ������ ������ �� �� �� ���� ������ �ȴ�.
        // Start is called before the first frame update

        public int gauge = 0;

        void Start()
        {
            //Debug.Log("���� �̸��� player�Դϴ�.");

            // �÷��̾��� ��ġ z : 40���� �̵��Ѵ�.
            // ���� Transform�� position�� z�� 40���� �ٲ��
            // 1. ��ġ �̵�
            transform.position = new Vector3(4.4f, 0.43f, 3.62f);

            // 2. ȸ��
            // -> transform.Rotate(new Vector3(0, 90, 0));
        }
        // �ݺ��Ǵ� ������ ó���� �� �ֽ��ϴ�.
        // Frame : 1�ʿ� 60Frame FPS : Frame Per second
        // 1Frame�� ������ �� update�� �� ���� ����ȴ�.
        // Update is called once per frame

        #endregion


        public int maxHealth;
        public int currentHealth;
        // #region���� ������ #endregion �� �Բ� �ٴ´�. = ������

        public int speed = 10;
        public bool isDash = false;
        public bool isgrounded;

        void Update()
        { 
            // �÷��̾��� �Է��� �����غ���.
            // Ű���� �Է� : 

            #region �÷��̾��� DŰ �Է�

            if (Input.GetKey(KeyCode.LeftShift))
            {
                isDash = true;
            }

            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                isDash = false;
            }

            if(isDash)
            {
                speed = 30;
            }
            else if (!isDash)
            {
                speed = 10;
            }

            if (Input.GetKey(KeyCode.D))
            {
                //Debug.Log("DŰ�� �Է� �߽��ϴ�."); // ������ �����δ�.

                transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);

            }

   

            if (Input.GetKeyUp(KeyCode.D))
            {
                //Debug.Log("DŰ�� �������ϴ�.");
            }


                #endregion

                /*#region �÷��̾��� ���� �Է�

                if (Input.GetKey(KeyCode.W))
                {
                    Debug.Log("������ �߽��ϴ�.");

                    transform.Translate(new Vector3(0, 10, 1) * Time.deltaTime);
                }
                #endregion*/

                #region �÷��̾��� A Ŭ�� �Է�

                if (Input.GetKey(KeyCode.A))
            {
                //Debug.Log("A�� Ŭ�� �߽��ϴ�.");
                transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
            }

            if(Input.GetKeyUp(KeyCode.A))
            {
                //Debug.Log("A Ŭ���� ���߾����ϴ�.");
            }

            #endregion

            // ���콺 �Է�

            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("���콺 ������ Ŭ�� �Ͽ����ϴ�.");
            }

            // �߷�
            //transform.Translate(new Vector3(0, -9.8f,0) * Time.deltaTime);

        }
    }
}
