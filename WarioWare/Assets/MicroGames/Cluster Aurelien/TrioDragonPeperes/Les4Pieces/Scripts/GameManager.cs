﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Testing;

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

            private SoundManager soundManager;
            private CoinManager coinManager;
            private CarteManager carteManager;
            public CoinController[] coinController;

            public GameObject fourthSpot;


            bool playerWon;

            public GameObject hideCoin;
            public Transform spot1;
            public Transform spot2;
            public Transform spot3;
            public Transform spot4;

            [SerializeField] GameObject Coco_Y;
            [SerializeField] GameObject Coco_X;
            [SerializeField] GameObject Coco_B;
            [SerializeField] GameObject Coco_A;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                coinManager = FindObjectOfType<CoinManager>();
                carteManager = FindObjectOfType<CarteManager>();
                soundManager = FindObjectOfType<SoundManager>();

                #region Spawn Coins
                if(currentDifficulty == Difficulty.EASY)
                {
                    coinManager.SpawnCoinsEasy();
                    coinController = FindObjectsOfType<CoinController>();
                }
                if (currentDifficulty == Difficulty.MEDIUM)
                {
                    coinManager.SpawnCoinsMedium();
                    coinController = FindObjectsOfType<CoinController>();
                }
                if (currentDifficulty == Difficulty.HARD)
                {
                    coinManager.SpawnCoinsHard();
                    coinController = FindObjectsOfType<CoinController>();
                }
                #endregion

                if (currentDifficulty != Difficulty.EASY)
                {
                    fourthSpot.SetActive(true);
                }

                soundManager.PlayMusic();
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

                if(currentDifficulty == Difficulty.EASY)
                {

                    if(Tick == 5)
                    {
                        enableInput = true;
                        HideCoins();
                        carteManager.SpawnRandomCarteEasy();
                    }


                    if(Tick == 8)
                    {
                        soundManager.StopMusic();
                        //le joueur n'a pas trouvé la bonne pièce à temps, il loose
                        if (playerWon)
                        {
                            Manager.Instance.Result(true);
                        }

                        if(!playerWon)
                        {
                            Manager.Instance.Result(false);
                        }
                    }
                }
                #endregion

                #region MediumMode

                if(currentDifficulty == Difficulty.MEDIUM)
                {


                    if (Tick == 5)
                    {
                        enableInput = true;
                        HideCoins();
                        carteManager.SpawnRandomCarteMedium();
                    }


                    if (Tick == 8)
                    {
                        soundManager.StopMusic();
                        //le joueur n'a pas trouvé la bonne pièce à temps, il loose
                        if (playerWon)
                        {
                            Manager.Instance.Result(true);
                        }

                        if (!playerWon)
                        {
                            Manager.Instance.Result(false);
                        }
                    }
                }

                #endregion

                #region HardMode

                if (currentDifficulty == Difficulty.HARD)
                {
                   /* if (Tick == 0)
                    {
                        coinManager.SpawnCoinsHard();
                        coinController = FindObjectsOfType<CoinController>();
                    }*/

                    if (Tick == 5)
                    {
                        enableInput = true;
                        HideCoins();
                        carteManager.SpawnRandomCarteHard();
                    }


                    if (Tick == 8)
                    {
                        soundManager.StopMusic();
                        //le joueur n'a pas trouvé la bonne pièce à temps, il loose
                        if (playerWon)
                        {
                            Manager.Instance.Result(true);
                        }

                        if (!playerWon)
                        {
                            Manager.Instance.Result(false);
                        }
                    }
                }

                #endregion
            }

            public void YouWIn()
            {
                soundManager.PlayFoule_N();
                playerWon = true;
            }

            public void YouLost()
            {
                soundManager.PlayFoule_P();
                soundManager.StopMusic();
            }

            public void HideCoins()
            {
                soundManager.PlayCoin();

                /*Instantiate(hideCoin, spot1);
                Instantiate(hideCoin, spot2);
                Instantiate(hideCoin, spot3);*/
                Coco_B.SetActive(true);
                Coco_X.SetActive(true);
                Coco_Y.SetActive(true);

                if (fourthSpot == true)
                {
                    //Instantiate(hideCoin, spot4);
                    Coco_A.SetActive(true);
                }
                
            }
        }
    }
}