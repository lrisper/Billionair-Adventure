using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text _textConponet;
    [SerializeField] State _startingState;
    [SerializeField] State[] _nextState;
    State _state;

    // Start is called before the first frame update
    void Start()
    {
        _state = _startingState;
        _textConponet.text = _state.GetStoryState();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = _state.GetNextState();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _state = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _state = nextState[1];
        }
        _textConponet.text = _state.GetStoryState();
    }
}
