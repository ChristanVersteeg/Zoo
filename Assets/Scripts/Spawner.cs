using UnityEngine;

namespace Zoo
{
    internal class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] animals;

        private void Start()
        {
            foreach (GameObject animal in animals)
                Instantiate(animal, transform);
        }
    }
}