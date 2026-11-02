using DG.Tweening;
using UnityEngine;

public class LevelPreviewManager : MonoBehaviour
{

    [SerializeField] float previewAnimationTime, previewOffset;
    PreviewImage previewImage;
    RectTransform previewImageRectT;

    void Awake()
    {
        InitializePreviewImageSystem();
    }

    void InitializePreviewImageSystem()
    {
        foreach (RectTransform _rectTransform in GetComponentsInChildren<RectTransform>())
        {
            if (_rectTransform.gameObject.GetComponent<PreviewImage>())
            {
                previewImageRectT = _rectTransform;
                break;
            }
        }

        previewImage = GetComponentInChildren<PreviewImage>();
    }


    public void AnimatePreviewWindow(bool _animateIn)
    {

        Debug.Log(previewImage.GetComponent<RectTransform>().rect.width);

        if (previewImageRectT != null) previewImageRectT.DOAnchorPosX(_animateIn ? previewOffset : previewImage.GetComponent<RectTransform>().rect.width, previewAnimationTime);


    }

}
