using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWallColliisions : MonoBehaviour
{

    #region Private Variables
    private LineRenderer m_MazeWalls;
    private EdgeCollider2D m_MazeWallColliders;
    #endregion

    private void Start()
    {
        m_MazeWalls = this.GetComponent<LineRenderer>();
        m_MazeWallColliders = this.GetComponent<EdgeCollider2D>();

        CreateMazeCollisions();
    }

    private void CreateMaze()
    {

    }

    private void CreateMazeCollisions()
    {
        int arraySize = m_MazeWalls.positionCount;

        Vector3[] mazeWallPointArrayV3 = new Vector3[arraySize];
        m_MazeWalls.GetPositions(mazeWallPointArrayV3);

        Vector2[] mazeWallPointArrayV2 = new Vector2[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            mazeWallPointArrayV2[i] = mazeWallPointArrayV3[i];
        }

        m_MazeWallColliders.points = mazeWallPointArrayV2;
    }

    public void GetWallPoints()
    {

    }

    public void SetWallPoints()
    {

    }
    
}
