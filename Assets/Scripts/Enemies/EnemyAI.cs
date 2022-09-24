using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {
    public float detectionRadiusSize;
    public LayerMask detectionLayer;

    private NavMeshAgent agent; 
    private Transform target;

    private void Start() {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update() {
        DetectObject();
        
        if (target == null) {
            return;
        }

        agent.SetDestination(target.position);

        if (agent.velocity.x < 0.01f) {
            this.transform.localScale = new Vector3(-1, 1, 1);
        } else if (agent.velocity.x > 0.01f) {
            this.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void DetectObject() {
        Collider2D collider = Physics2D.OverlapCircle(this.transform.position, detectionRadiusSize, detectionLayer);
        if (collider != null) {
            target = collider.transform;
        } else {
            target = null;
        }
    }
}