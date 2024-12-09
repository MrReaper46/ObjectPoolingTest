using System.Collections;
using UnityEngine;

public class MinionMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _checkPoints;
    [SerializeField] private int moveSpd = 5;
    [SerializeField] private int rotateSpd = 5;
    [SerializeField] private int _currentCheckPointIndex = 0;
    [SerializeField] private Transform _currentCheckPoint;
    [SerializeField] private Transform _nextCheckPoint;
    public int CurrentCheckPointIndex => _currentCheckPointIndex;

    private void Reset()
    {
        this.LoadCheckPointCtrl();
    }

    private void OnEnable()
    {
        this.StartCoroutine(MoveThroughCheckPoints());
    }
    private void FixedUpdate()
    {
        this.UpdateCheckPoint();
    }
    private void LoadCheckPointCtrl()
    {
        _checkPoints = GameObject.Find("CheckPointCtrl").GetComponent<CheckPoint_Ctrl>().CheckPoints;
        _currentCheckPointIndex = 0;
        _currentCheckPoint = _checkPoints[_currentCheckPointIndex];
        _nextCheckPoint = _checkPoints[_currentCheckPointIndex++];
    }

    private void UpdateCheckPoint()
    {
        if(transform.parent.position == _checkPoints[0].position || transform.parent.position == _checkPoints[_checkPoints.Length - 1].position)
        {

        }
    }

    IEnumerator MoveThroughCheckPoints()
    {
        if (transform.parent.position == _checkPoints[0].position || transform.parent.position == _checkPoints[_checkPoints.Length - 1].position)
        {
            yield return null;
        }
        for (int i = 0; i < _checkPoints.Length; i++)
        {
            while (Vector3.Distance(transform.position, _checkPoints[i].position) > 0.1f)
            {
                transform.parent.position = Vector3.MoveTowards(transform.position, _checkPoints[i].position, moveSpd * Time.deltaTime);
                yield return null;
            }
            yield return StartCoroutine(RotateAtCheckPoint());
        }
        yield return new WaitForSeconds(0.25f);
    }
    IEnumerator RotateAtCheckPoint()
    {
        Debug.Log("Start Rotation");
        if (transform.parent.position == _checkPoints[0].position || transform.parent.position == _checkPoints[_checkPoints.Length - 1].position)
        {
            yield return null;
        }
        //transform.parent.rotation = Quaternion.RotateTowards(transform.parent.rotation, _checkPoints[i].rotation, rotateSpd * Time.deltaTime);
        yield return new WaitForSeconds(0.25f);
    }

}
