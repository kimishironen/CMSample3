using Caliburn.Micro;

namespace CMSample3
{
    public class ShellViewModel :
        Conductor<Screen>.Collection.OneActive, IShell
    {
        public ShellViewModel()
        {
            this.ActivateItem(new BaseViewModel());
        }
    }
}