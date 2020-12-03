using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonsPeperes
{
    namespace Les4Pieces
    {
        public class TestList2 : TimedBehaviour
        {
            public List<GameObject> symboles = new List<GameObject>();

           // public Vector3[] positions = new Vector3[symboles.Count];

           //  Random.Range   

            //va te faire enculer
            public override void Start()
            {
                //for (int i = 0; i<symboles.Count; i++)
               // {
               //     Instantiate(symboles[i], positions[i], Quaternion.identity);
               // }

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
                
            }
        }
    }
}