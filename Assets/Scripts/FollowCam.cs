using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    public Transform target;          // ������ Ÿ�� ������Ʈ�� Transform
    public float dist = 10.0f;        // ī�޶���� ���� �Ÿ�
    public float height = 5.0f;       // ī�޶��� ���� ����
    public float smoothRotate = 5.0f; // �ε巯�� ȸ���� ���� ����

    private Transform tr;             // ī�޶� �ڽ��� Transform ����

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void LateUpdate()
    {

        // �ε巯�� ȸ���� ���� Mathf.LerpAngle
        float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, smoothRotate * Time.deltaTime);

        // ���Ϸ� Ÿ���� ���ʹϾ����� �ٲٱ�
        Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

        // ī�޶� ��ġ�� Ÿ�� ȸ��������ŭ ȸ�� �� dist�� ŭ ����, ���̸� �ø���
        tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);

        // Ÿ���� �ٶ󺸰� �ϱ�
        tr.LookAt(target);
    }
}
