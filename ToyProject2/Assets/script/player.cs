using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class player : MonoBehaviour
    {
        #region �� ����

        // ������ ������ �� �� �� ���� ������ �ȴ�.
        // Start is called before the first frame update

        public int gauge = 0;

        void Start()
        {
            Debug.Log("���� �̸��� player�Դϴ�.");

            // �÷��̾��� ��ġ z : 40���� �̵��Ѵ�.
            // ���� Transform�� position�� z�� 40���� �ٲ��
            // 1. ��ġ �̵�
            transform.position = new Vector3(3.43f, 16.33f, -4f);

            // 2. ȸ��
            // -> transform.Rotate(new Vector3(0, 90, 0));
        }
        // �ݺ��Ǵ� ������ ó���� �� �ֽ��ϴ�.
        // Frame : 1�ʿ� 60Frame FPS : Frame Per second
        // 1Frame�� ������ �� update�� �� ���� ����ȴ�.
        // Update is called once per frame

        #endregion


        // #region���� ������ #endregion �� �Բ� �ٴ´�. = ������

        public bool isgrounded;

        void Update()
        {
            // �÷��̾��� �Է��� �����غ���.
            // Ű���� �Է� : 

            #region �÷��̾��� DŰ �Է�

            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("DŰ�� �Է� �߽��ϴ�."); // ������ �����δ�.

                transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime);

            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("DŰ�� �������ϴ�.");
            }

            #endregion

            #region �÷��̾��� ���� �Է�

            if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("������ �߽��ϴ�.");

                transform.Translate(new Vector3(0, 10, 1) * Time.deltaTime);
            }
            #endregion

            #region �÷��̾��� A Ŭ�� �Է�

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A�� Ŭ�� �߽��ϴ�.");
            }

            if(Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log("A Ŭ���� ���߾����ϴ�.");
            }

            #endregion

            // ���콺 �Է�

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("���콺 ������ Ŭ�� �Ͽ����ϴ�.");
            }

            // �߷�
            //transform.Translate(new Vector3(0, -9.8f,0) * Time.deltaTime);

        }
    }
}
