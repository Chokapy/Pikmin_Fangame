using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings.WSA;

public class OnionColor : MonoBehaviour
{
    public Animator animator;
    private Variables variables;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        variables = GetComponent<Variables>();
    }

    // Update is called once per frame
    void Update()
    {
        int Count = -1;

        bool red = (bool)variables.declarations.Get("Red");
        bool yellow = (bool)variables.declarations.Get("Yellow");
        bool blue = (bool)variables.declarations.Get("Blue");
        bool rock = (bool)variables.declarations.Get("Rock");
        bool winged = (bool)variables.declarations.Get("Winged");
        bool purple = (bool)variables.declarations.Get("Purple");
        bool white = (bool)variables.declarations.Get("White");
        bool ice = (bool)variables.declarations.Get("Ice");

        if (red)
        {
            Count++;
        }
        if (yellow)
        {
            Count++;
        }
        if (blue)
        {
            Count++;
        }
        if (rock)
        {
            Count++;
        }
        if (winged)
        {
            Count++;
        }
        if (purple)
        {
            Count++;
        }
        if (white)
        {
            Count++;
        }
        if (ice)
        {
            Count++;
        }

        animator.SetFloat("Level", Count);
    }
}
