using UnityEngine;

public class CheckPoint_Ctrl : MonoBehaviour
{
    [SerializeField] private Transform[] _checkPoints;
    public Transform[] CheckPoints => _checkPoints;


    private void Reset()
    {
        this.LoadCheckPoints();
    }
    private void LoadCheckPoints()
    {
        int cornerCount = 0;
        foreach (Transform child in GameObject.Find("Path").transform)
        {
            if (child.Find("CheckPoint_Corner"))
            {
                cornerCount++;
            }
        }
        _checkPoints = new Transform[cornerCount + 2];

        _checkPoints[0] = GameObject.Find("CheckPoint_Start").transform;

        _checkPoints[_checkPoints.Length - 1] = GameObject.Find("CheckPoint_End").transform;

        for (int i = 1; i < _checkPoints.Length - 1; i++)
        {
            string corner = "Tile_Corner_" + i;
            if (cornerCount == 0) break;
            _checkPoints[i] = GameObject.Find(corner).transform;
        }
    }
}
