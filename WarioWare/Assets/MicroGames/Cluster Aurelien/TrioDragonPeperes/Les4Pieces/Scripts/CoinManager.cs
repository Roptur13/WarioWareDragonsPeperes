using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Dragons_Peperes
{
    namespace Les4Pieces
    {
        /// <summary>
        /// Mael Ricou
        /// </summary>
        public class CoinManager : MonoBehaviour
        {
            public List<GameObject> coins = new List<GameObject>();

            public List<GameObject> spots = new List<GameObject>();

            public List<GameObject> hiddenCoin = new List<GameObject>();

            public void SpawnCoins()
            {
                for (int i = 0; i < spots.Count; i++)
                {
                    int rand = Random.Range(0, coins.Count);
                    Instantiate(coins[rand], spots[i].transform.position, Quaternion.identity);
                    coins.RemoveAt(rand);
                }
            }

        }
    }
}
