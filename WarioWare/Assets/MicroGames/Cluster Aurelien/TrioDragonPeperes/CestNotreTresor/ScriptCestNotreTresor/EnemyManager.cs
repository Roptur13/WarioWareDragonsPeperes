﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace CestNotreTresor
    {
        /// <summary>
        /// Mael Ricou
        /// </summary>

        public class EnemyManager : TimedBehaviour
        {

            public GameObject enemy;


            public override void Start()
            {
                base.Start(); //Do not erase this line!

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {
                base.TimedUpdate();
                if (Tick == 1)
                    Debug.Log("audio: COME BACK HERE");

                if (Tick == 2)
                    Instantiate(enemy, transform.position, transform.rotation);

                if (Tick == 3)
                    Debug.Log("Frer stp_3");

                if (Tick == 4)
                    Debug.Log("Frer stp_4");

                if (Tick == 5)
                    Instantiate(enemy, transform.position, transform.rotation);

                if (Tick == 6)
                    Debug.Log("Frer stp_6");

                if (Tick == 7)
                    Debug.Log("la poupe du bateau apparait + end of scrolling");

                if (Tick == 8)
                {
                    Debug.Log("Victoire ou défaite telle est la question");
                }
                    

            }
        }
    }
}