using UnityEngine;

namespace Zoo
{
    internal class Spawner : MonoBehaviour
    {
        [SerializeField] private Transform parent;
        [SerializeField] private GameObject[] animals;

        private void Start()
        {
            foreach (GameObject animal in animals)
            {
                GameObject newAnimal = Instantiate(animal, parent);
                newAnimal.name = animal.name;
            }
        }
    }
}