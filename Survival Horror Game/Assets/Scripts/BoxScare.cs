using UnityEngine;

public class BoxScare : MonoBehaviour
{
    public GameObject hiddenCube;

    void OnTriggerEnter(Collider other)
    {
        hiddenCube.SetActive(false);
    }
}
