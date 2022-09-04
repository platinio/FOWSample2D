using UnityEngine;

namespace Fow
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float m_speed = 5;

        private void Update()
        {
            Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
            transform.position += dir * m_speed * Time.deltaTime;
        }
    }

}

