public class PopupSystem<TData> : BasePopUp
{
    public virtual void Open(TData setupData) { }
    protected virtual void Setup(TData data) { }
}