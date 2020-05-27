using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeautifulUI.ViewModels
{
    public class SciodeskViewModel : BaseViewModel
    {
        public ICommand SkeletonCommand => new Command(async () =>
        {
            IsBusy = true;
            await Task.Delay(4000);
            IsBusy = false;
        });

        public ICommand RefreshCommand => new Command(async () => await OnRefreshAsync());

        private async Task OnRefreshAsync()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }
    }
}
