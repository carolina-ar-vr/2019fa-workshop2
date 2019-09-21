using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float shootDistance = 100f;
    public int pointsPerHit = 1;
    public ScoreKeeper scoreKeeper;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, shootDistance)) {
                if (hit.transform.CompareTag("Fruit")) {
                    Destroy(hit.transform.gameObject);
                    scoreKeeper.AdjustScore(pointsPerHit);
                }
            }
        }
    }
}
