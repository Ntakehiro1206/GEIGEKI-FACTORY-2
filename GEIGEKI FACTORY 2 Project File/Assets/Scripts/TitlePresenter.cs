using UnityEngine;

public class TitlePresenter : MonoBehaviour
{
    private readonly TitleView _titleView;
    private readonly TitleModel _titleModel;

    public TitlePresenter(TitleView titleView, TitleModel titleModel)
    {
        _titleView = titleView;
        _titleModel = titleModel;
    }
}