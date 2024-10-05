using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Classstudy
{
    public class ballspawner : MonoBehaviour
    {
        public GameObject ballPrefab;
        public Transform[] spawnPosition;

        public GameObject CurrentObject;

        public float SpawnTime = 0.5f;
        float timeChecker = 0f;

        // Start is called before the first frame update
        void Start()
        {
            CurrentObject = Spawner();
        }

        private GameObject Spawner()
        {
            int RandomIndex = Random.Range(0, 2);
            return CurrentObject = Instantiate(ballPrefab, spawnPosition[RandomIndex]);
        }

        // Update is called once per frame
        void Update()
        {
            timeChecker = timeChecker + Time.deltaTime;

            if(timeChecker >= SpawnTime)
            {
                Spawner();
                timeChecker = 0;
            }

            //if(CurrentObject == null)
            //    Spawner();
        }
    }
}
