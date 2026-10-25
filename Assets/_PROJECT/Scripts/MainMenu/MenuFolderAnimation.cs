using DG.Tweening;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuFolderSelectionManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    [SerializeField] float animationDistance, AnimationTime;

    float originalLocalPostion;

    private void Start()
    {
        originalLocalPostion = transform.localPosition.y;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        AnimateButton(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        AnimateButton(false);
    }


    void AnimateButton(bool _animateButton)
    {
        if (_animateButton)
        {
            transform.DOLocalMoveY(originalLocalPostion + animationDistance, AnimationTime);
        }
        else
        {
            transform.DOLocalMoveY(originalLocalPostion, AnimationTime);
        }
    }
}
