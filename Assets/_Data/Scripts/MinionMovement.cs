using System.ComponentModel;
using UnityEngine;

public class MinionMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _checkPoints;
    [SerializeField] private int moveSpd = 5;
    [SerializeField] private int rotateSpd = 5;
    [SerializeField] private Transform _currentCheckPoint;
    [SerializeField] private Transform _nextCheckPoint;

    private void Reset()
    {
        LoadCheckPointCtrl();
    }

    private void OnEnable()
    {
        this._currentCheckPoint = _checkPoints[1];
        this._nextCheckPoint = _checkPoints[0];
    }
    private void LoadCheckPointCtrl()
    {
        _checkPoints = GameObject.Find("CheckPointCtrl").GetComponent<CheckPoint_Ctrl>().CheckPoints;
    }
    private void FixedUpdate()
    {

    }
}
