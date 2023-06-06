using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class BringMissionController : MonoBehaviour
{
    [SerializeField] GameObject Menu;

    Animator Animator;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Animator.speed = 1;
                Animator.Play("bringMission");
            }
            if (Input.GetKeyUp(KeyCode.M)) Animator.SetTrigger("take");
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            Menu.SetActive(canMove);
            canMove = !canMove;
        }
    }

}
