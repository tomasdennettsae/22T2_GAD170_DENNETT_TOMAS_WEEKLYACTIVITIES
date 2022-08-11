using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TomasDennett
{
    public class ResetCounter : MonoBehaviour
    {
        public delegate void MarbleResetAction();
        public static event MarbleResetAction OnMarbleReset;

        // we need to have a COUNTER...
        [SerializeField] private int resetCount = 0;

        // ...and we need to increase the counter's value every time the marble resets.

        // We need to start and stop listening to the OnMarbleReset event
        private void OnEnable()
        {
            OnMarbleReset += IncreaseResetCount;
        }

        private void OnDisable()
        {
            OnMarbleReset -= IncreaseResetCount;
        }

        // when the OnMarbleReset event is announced...
        private void IncreaseResetCount()
        {
            // ...we want to increase the counter's value
        }
    }
}