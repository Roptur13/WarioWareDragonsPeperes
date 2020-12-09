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
        public class CoinManager : MonoBehaviour
        {
            public List<GameObject> coins = new List<GameObject>();

            public List<GameObject> spots = new List<GameObject>();

            public GameObject spot1;


            private void Start()
            {
                //SpawnCoins();

                for(int i = 0; i < spots.Count; i++)
                {
                    int rand = Random.Range(0, coins.Count);
                    Instantiate(coins[rand], spots[i].transform.position, Quaternion.identity);
                    coins.RemoveAt(rand);
                }

            }

            private void SpawnCoins()
            {
                int count = coins.Count;
                if(count == 0)
                {
                    return;
                }

                int i = Random.Range(0, count - 1);
                GameObject go = coins[i];
                coins.Remove(go);

                Instantiate(go, spot1.transform);

            }
        }
    }
}
