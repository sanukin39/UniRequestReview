using UnityEngine;
using UnityEngine.UI;

namespace Sanukin39
{
    public class UniRequestReviewSample : MonoBehaviour
    {
        [SerializeField] Button requestReviewButton;

        void Start()
        {
            requestReviewButton.onClick.AddListener(() => {
                UniRequestReview.RequestReview();
            });
        }
    }
}
