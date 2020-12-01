using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dragons_Peperes
{
    namespace ChasseAuTresor
    {
        /// <summary>
        /// Noé Blanc
        /// </summary>

        public class InputsChoiceScript : TimedBehaviour
        {
            private string[] easyInputPossibility1 = new string[] { "Haut", "Bas", "Droite" };
            private string[] easyInputPossibility2 = new string[] { "Bas", "Bas", "Gauche" };
            private string[] easyInputPossibility3 = new string[] { "Gauche", "Haut", "Gauche" };
            private string[] easyInputPossibility4 = new string[] { "Droite", "Bas", "Gauche" };
            private string[] easyInputPossibility5 = new string[] { "Haut", "Gauche", "Haut" };

            private int possibilityNumber;

            public override void Start()
            {
                base.Start(); //Do not erase this line!

                possibilityNumber = Random.Range(1, 6);

                switch(possibilityNumber)
                {
                    case 1 :

                        break;
                    case 2 :
                        break;
                    case 3 :
                        break;
                    case 4 :
                        break;
                    case 5 :
                        break;
                }

            }

            //FixedUpdate is called on a fixed time.
            public override void FixedUpdate()
            {
                base.FixedUpdate(); //Do not erase this line!

            }

            //TimedUpdate is called once every tick.
            public override void TimedUpdate()
            {

            }
        }
    }
}