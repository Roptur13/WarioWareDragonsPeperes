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
        public class SwitchCoins : MonoBehaviour
        {
            public GameObject[] arrayOfCoins;


            private void Update()
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SwitchThem();
                }
            }

            public void SwitchThem()
            {

            }


        }
    }   
}
