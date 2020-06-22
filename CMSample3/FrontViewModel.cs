using Caliburn.Micro;

namespace CMSample3
{
    class FrontViewModel : Screen
    {
        public void hoge()
        {
            ((IShell)this.Parent).ActivateItem(new FrontViewModel());
        }
    }
}