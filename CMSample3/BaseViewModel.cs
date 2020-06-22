using Caliburn.Micro;

namespace CMSample3
{
    class BaseViewModel : Screen
    {
        public void DisplayFront()
        {
            ((IShell)this.Parent).ActivateItem(new FrontViewModel());
        }
    }
}