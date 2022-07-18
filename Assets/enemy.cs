using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class enemy : MonoBehaviour
{
    [SerializeField] Transform w1, w2, w3, w4, w5, w6, w7, w8, w9, w10,w11,w12;

    private NavMeshAgent agent;
     Transform movePositionTransform;
     Transform movePositionTransform2;
    int prev = 0;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        movePositionTransform = w6;
    }

    private void Update()
    {
        agent.destination = movePositionTransform.position;
        int ycount = Random.Range(1, 12);

        while (prev == ycount)
        {
            ycount = Random.Range(1, 12);
        }
        switch (ycount)
        {
            case 1:
                movePositionTransform2 = w1;
                break;
            case 2: 
                movePositionTransform2 = w2;
                break;
            case 3:
                movePositionTransform2 = w3;
                break;
            case 4:
                movePositionTransform2 = w4;
                break;
            case 5:
                movePositionTransform2 = w5;
                break;
            case 6:
                movePositionTransform2 = w6;
                break;
            case 7:
                movePositionTransform2 = w7;
                break;
            case 8:
                movePositionTransform2 = w8;
                break;
            case 9:
                movePositionTransform2 = w9;
                break;
            case 10:
                movePositionTransform2 = w10;
                break;
            case 11:
                movePositionTransform2 = w11;
                break;
            case 12:
                movePositionTransform2 = w12;
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "C1")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c2")
        {
            movePositionTransform = movePositionTransform2; 
        }
        else if (other.tag == "c3")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c4")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c5")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c6")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c7")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c8")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c9")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c10")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c11")
        {
            movePositionTransform = movePositionTransform2;
        }
        else if (other.tag == "c12")
        {
            movePositionTransform = movePositionTransform2;
        }
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
