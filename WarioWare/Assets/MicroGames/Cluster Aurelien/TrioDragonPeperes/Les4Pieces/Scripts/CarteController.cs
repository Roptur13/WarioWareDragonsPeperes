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

        public class CarteController : MonoBehaviour
        {
            [SerializeField] bool isCarte1;
            [SerializeField] bool isCarte2;
            [SerializeField] bool isCarte3;
            [SerializeField] bool isCarte4;

            private CarteManager carteManager;

            private void Start()
            {
                carteManager = FindObjectOfType<CarteManager>();

                if (isCarte1)
                {
                    carteManager.weWantCoin1 = true;
                }

                if (isCarte2)
                {
                    carteManager.weWantCoin2 = true;
                }

                if (isCarte3)
                {
                    carteManager.weWantCoin3 = true;
                }

                if (isCarte4)
                {
                    carteManager.weWantCoin4 = true;
                }
            }
        }
    }
}
