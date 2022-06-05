using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBucketList.Mobile.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, IInitializeAsync, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;

        private string _description;

        private string _period;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        public string Period
        {
            get { return _period; }
            set { SetProperty(ref _period, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        public Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }
    }
}
