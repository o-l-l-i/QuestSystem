using UnityEngine;


public class Player : Actor
{

    public float positionX;
    public float positionY;

    public Vector2 PositionVector2 { get { return new Vector2(positionX, positionY); } set { positionX = value.x; positionY = value.y; } }
    public Vector2Int PositionVector2Int { get { return new Vector2Int((int)positionX, (int)positionY); } set { positionX = value.x; positionY = value.y; } }

    public Vector3 PositionVector3 { get { return new Vector3(positionX, positionY, 0); } set { positionX = value.x; positionY = value.y; } }
    public Vector3Int PositionVector3Int { get { return new Vector3Int((int)positionX, (int)positionY, 0); } set { positionX = value.x; positionY = value.y; } }

    public PlayerStats stats;

    public Inventory inventory;

}