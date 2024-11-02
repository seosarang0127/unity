using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class HPSystem : MonoBehaviour
    {
        [SerializeField] private int hp;   // ���� ü��
        public int maxHP; // �ִ� ü��

        public GameObject[] lifeCount;
        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;    // hp ���� value�� �������ּ���.
                Debug.Log("ü���� ����Ǿ����ϴ�.");

                if (hp >= maxHP ) hp = maxHP; // �ִ� ü���� ���� �� �ϰ� �Ѵ�.

                if (hp <= 0) hp = 0;

                Update();
            }
        }

        void UpdateUI()
        {

        }


        public void DecreaseHP(int damage = 1) // enemy
        {
            HP -= damage;
        }

        public void IncreaseHP(int value = 1) // enemy
        {
            HP += value;
        }

        private void Start()
        {
            hp = maxHP;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                DecreaseHP();
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                IncreaseHP();
            }
        }
    }

}
