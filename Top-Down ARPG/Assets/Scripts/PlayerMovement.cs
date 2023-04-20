using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    const float movementAnimationSmoothTime = .1f;

    private NavMeshAgent navMeshAgent;
    private Animator anim;
    public Camera cam;


    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
        //cam = Camera.main;
    }

    
    void Update()
    {
        float speedPercent = navMeshAgent.velocity.magnitude / navMeshAgent.speed;
        anim.SetFloat("speedPercent", speedPercent, movementAnimationSmoothTime, Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            MoveToPoint(GetMousePositionInWorld());
        }
    }

    public void MoveToPoint(Vector3 point)
    {
        navMeshAgent.SetDestination(point);
    }

    private Vector3 GetMousePositionInWorld()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            return hit.point;
        }

        return Vector3.zero;
    }
}
