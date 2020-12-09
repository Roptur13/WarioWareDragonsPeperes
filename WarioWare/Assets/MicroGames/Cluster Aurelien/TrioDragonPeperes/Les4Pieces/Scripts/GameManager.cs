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
        public class GameManager : TimedBehaviour
        {

            public bool enableInput;

            private CoinManager coinManager;
            private CarteManager carteManager;
            public CoinController[] coinController;


            public override void Start()
            {
                base.Start(); //Do not erase this line!

                coinManager = FindObjectOfType<CoinManager>();
                carteManager = FindObjectOfType<CarteManager>();
                

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                #region EasyMode

                if(currentDifficulty == Testing.Manager.Difficulty.EASY)
                {
                    if(Tick == 1)
                    {
                        coinManager.SpawnCoins();
                        coinController = FindObjectsOfType<CoinController>();
                    }

                    if(Tick == 4)
                    {
                        
                    }

                    if(Tick == 5)
                    {

                        enableInput = true;
                        for (int i = 0; i < coinController.Length; i++)
                        {
                            coinController[i].hideCoins = true;
                        }

                        carteManager.SpawnRandomCarte();

                    }

                    if(Tick == 6)
                    {

                    }

                    if(Tick == 8)
                    {
                        //le joueur n'a pas trouvé la bonne pièce à temps, il loose
                        YouLost();
                    }
                }

                #endregion



            }

            public void YouWIn()
            {
                Testing.Manager.Instance.Result(true);
            }

            public void YouLost()
            {
                Testing.Manager.Instance.Result(false);
            }
        }
    }
}