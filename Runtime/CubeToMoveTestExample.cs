using UnityEngine;

public class CubeToMoveTestExample : MonoBehaviour
{
    [SerializeField] Transform m_cubeToMove;
    private Vector3 m_changeScale;
    private Vector3 m_direction;
    public void ChangeScale(float changedValue)
    {
        m_changeScale = new Vector3(changedValue, changedValue, changedValue);
    }
    public void ChangeX(float changedValue)
    {
        m_direction = new Vector3(changedValue, 0, 0);
    }
    public void ChangeY(float changedValue)
    {
        m_direction = new Vector3(0, changedValue, 0) ;
    }
    public void ChangeZ(float changedValue)
    {
        m_direction = new Vector3(0, 0, changedValue) ;
    }

    private void Update()
    {
        m_cubeToMove.localScale += m_changeScale * Time.deltaTime * 1f;
        m_cubeToMove.transform.position += m_direction * Time.deltaTime * 50f;
    }
}
