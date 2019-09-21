using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public float delay = 3f;
    public float rate = 1f;
    public float upForce = 15f;
    public float offsetForce = 3f;
    public GameObject[] fruitPrefabs;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(delay);
        while (this.isActiveAndEnabled) {
            yield return new WaitForSeconds(1/rate);

            GameObject prefab = fruitPrefabs[Random.Range(0, fruitPrefabs.Length)];
            GameObject go = Instantiate(prefab, transform.position, Quaternion.identity);
            Rigidbody rb = go.GetComponent<Rigidbody>();

            rb.AddForce(Vector3.up*upForce + Random.insideUnitSphere*offsetForce, ForceMode.Impulse);
        }
    }
}
