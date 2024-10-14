using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    private TopDownController controller;

    public CinemachineVirtualCamera _virtualCamera;

    [SerializeField]
    private float MaxZoom = 10;
    [SerializeField]
    private float MinZoom = 5;
    [SerializeField]
    private float ZoomSpeed = 0.2f;


    private void Start()
    {
       
        controller.OnZoomEvent += CameraZoom;

    }


    private void Awake()
    {

        controller = GetComponent<TopDownController>();
        _virtualCamera = GetComponent<CinemachineVirtualCamera>();

    }


    private void CameraZoom(float ScrollY)
    {

        float targetOrtho = _virtualCamera.m_Lens.OrthographicSize;
        float target = Mathf.Clamp(targetOrtho + ScrollY, MinZoom, MaxZoom);
        _virtualCamera.m_Lens.OrthographicSize = Mathf.Lerp(targetOrtho, target, ZoomSpeed * Time.deltaTime);

    }


}
