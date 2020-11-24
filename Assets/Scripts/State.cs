using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject 
{
    // 14 ref's min size of the inspector for text field
    // amount of lines before scroll happens
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates; 

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
