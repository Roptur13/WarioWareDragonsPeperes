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
        public class CarteManager : MonoBehaviour
        {


            public GameObject spotCarte;
            public List<GameObject> cartes;

            public bool weWantCoin1;
            public bool weWantCoin2;
            public bool weWantCoin3;
            public bool weWantCoin4;

            public void SpawnRandomCarte()
            {
                int count = cartes.Count;
                if (count == 0)
                {
                    return;
                }

                int i = Random.Range(0, count - 1);
                GameObject go = cartes[i];
                cartes.Remove(go);

                Instantiate(go, spotCarte.transform);
            }

            private void Update()
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SpawnRandomCarte();
                }
            }

        }
    }
}
