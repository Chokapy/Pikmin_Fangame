using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnionColor : MonoBehaviour
{
    public Animator animator;
    private Variables variables;
    public Material material;
    public List<string> HexColors = new List<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        variables = GetComponent<Variables>();
    }

    // Update is called once per frame
    void Update()
    {
        int Count = -1;
        HexColors.Clear();

        if ((bool)variables.declarations.Get("Red"))
        {
            HexColors.Add("#FF0000");
            Count++;
        }

        if ((bool)variables.declarations.Get("Yellow"))
        {
            HexColors.Add("#FFFF00");
            Count++;
        }

        if ((bool)variables.declarations.Get("Blue"))
        {
            HexColors.Add("#0000FF");
            Count++;
        }

        if ((bool)variables.declarations.Get("Rock"))
        {
            HexColors.Add("#575757");
            Count++;
        }

        if ((bool)variables.declarations.Get("Winged"))
        {
            HexColors.Add("#ff00dd");
            Count++;
        }

        if ((bool)variables.declarations.Get("Purple"))
        {
            HexColors.Add("#8800ff");
            Count++;
        }

        if ((bool)variables.declarations.Get("White"))
        {
            HexColors.Add("#cccccc");
            Count++;
        }

        if ((bool)variables.declarations.Get("Ice"))
        {
            HexColors.Add("#00aaff");
            Count++;
        }

        for (int i = 0; i < HexColors.Count; i++)
        {
            if (UnityEngine.ColorUtility.TryParseHtmlString(HexColors[i], out Color color))
            {
                material.SetColor($"_TargetColor{i + 1}", color);
            }
        }

        animator.SetFloat("Level", Count);
    }
}
