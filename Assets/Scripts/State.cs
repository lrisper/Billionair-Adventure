using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string _storyText;
    [SerializeField] State[] _nextStates;

    public string GetStoryState()
    {
        return _storyText;
    }

    public State[] GetNextState()
    {
        return _nextStates;
    }
}

