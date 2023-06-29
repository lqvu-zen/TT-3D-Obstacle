using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]  float m_playerMoveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerXValue = Input.GetAxis("Horizontal") * Time.deltaTime * m_playerMoveSpeed;
        float playerZValue = Input.GetAxis("Vertical") * Time.deltaTime * m_playerMoveSpeed;
        transform.Translate(playerXValue, 0f, playerZValue);
    }
}
