using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCatcher : MonoBehaviour
{
    public int pointsPerMiss = -2;

    private ScoreKeeper scoreKeeper;
    private void Start() {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Fruit")) {
            Destroy(other.gameObject);
            scoreKeeper.AdjustScore(pointsPerMiss);
        }
    }
}
