using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SS.UI;

public class FinishLevelController : MonoBehaviour, IKeyBack
{
    public const string NAME = "FinishLevel";

    public void OnKeyBack()
    {
        Core.Close();
    }
}