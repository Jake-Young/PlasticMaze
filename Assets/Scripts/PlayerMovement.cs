using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region Private Variables
    private float m_HorizontalMovement = 0.0f;
    private float m_VerticalMovement = 0.0f;
    private Rigidbody2D m_PlayerRigidBody;

    [SerializeField]
    private float m_Speed = 2.0f;
    #endregion

    private void Start()
    {
        m_PlayerRigidBody = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_HorizontalMovement = Input.GetAxis("Horizontal");
        m_VerticalMovement = Input.GetAxis("Vertical");
        this.transform.Translate(new Vector3(m_HorizontalMovement, 0, 0) * Time.deltaTime * m_Speed);
        this.transform.Translate(new Vector3(0, m_VerticalMovement, 0) * Time.deltaTime * m_Speed);
    }
}
