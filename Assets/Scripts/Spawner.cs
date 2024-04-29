using UnityEngine;

namespace Zoo
{
    internal class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
        }
    }
}