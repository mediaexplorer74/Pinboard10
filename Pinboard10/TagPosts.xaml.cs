// TagPosts

using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Pinboard10.Common;
using PinboardDomain.Model;
using PinboardDomain.Repository;
using PinboardDomain.ViewModels;


// Pinboard10 namespace
namespace Pinboard10
{
    // TagPosts class
    public sealed partial class TagPosts : Page
    {
        // nav. helper
        private NavigationHelper navigationHelper;

        // default vm
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        
        // all tags
        private ObservableCollection<ITag> _allTags;

        // default vm
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        // TagPosts
        public TagPosts()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;

            BottomBar.Closed += BottomBarClosed;

        }//TagPosts end


        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>

        // navigationHelper_LoadState
        private async void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            PinboardApiWrapper api = new PinboardApiWrapper();
            
            this.DataContext = new TagPostsViewModel(api, e.NavigationParameter as string);

            _allTags = await api.GetTagsAsync();
        }//navigationHelper_LoadState end


        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        /// 
        // navigationHelper_SaveState
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
            //
        }//navigationHelper_SaveState end


        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="Common.NavigationHelper.LoadState"/>
        /// and <see cref="Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        // OnNavigatedTo
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }//OnNavigatedTo end


        // OnNavigatedFrom
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);

        }//OnNavigatedFrom end

        #endregion


        // PostSelected
        private void PostSelected(object sender, SelectionChangedEventArgs e)
        {
            if (PostsListView.SelectedItem != null)
            {
                BottomBar.IsOpen = true;
            }

        }//PostSelected end


        // BottomBarClosed
        private void BottomBarClosed(object sender, object e)
        {
            PostsListView.SelectedItem = null;

        }//BottomBarClosed end


        // AppBar_EditButton_Click
        private void AppBar_EditButton_Click(object sender, RoutedEventArgs e)
        {
            var post = PostsListView.SelectedItem as Bookmark;
            var appBarButton = sender as AppBarButton;
            var postDetails = new PostDetailsViewModel()
            {
                Url = post.Url,
                Title = post.Title,
                Tags = post.Tags,
                Time = post.Time,
                AllTags = _allTags.ToList()
            };
            
            appBarButton.DataContext = post;

        }//AppBar_EditButton_Click end

    }//class end

}//namespace end
