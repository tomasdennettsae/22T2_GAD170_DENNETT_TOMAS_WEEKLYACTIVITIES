using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TomasDennett
{
    public class Week8Activities : MonoBehaviour
    {
        public enum Fruit
        {
            Apple,
            Banana,
            Cherry,
            Peach,
            Mandarin,
            Pineapple,
            Mango




        }
        public Fruit favouriteFruit = Fruit.Mandarin;

        public Fruit[] myFruitBasket = new Fruit[10];

        // Update is called once per frame
        void Start()
        {
            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                myFruitBasket[i] = Fruit.Mandarin;

                Debug.Log(myFruitBasket[i]);
                    
            }
        }

        private void CheckFruit(Fruit typeOfFruit)
        {
            // We want to output different text depending on which fruit was chosen.
            // If it is an apple, do X.
            // If it is a banana, do Y.
            // ...etc

            switch (typeOfFruit)
            {
                case Fruit.Apple:
                    break;
                case Fruit.Banana:
                    break;
                case Fruit.Mango:
                    // YES; MANGOS
                    break;
                default:
                    break;
            }
        }
    }
}

