// MainPage

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using PinboardDomain.Model;
using PinboardDomain.Repository;
using PinboardDomain.ViewModels;

// Pinboard10 namespace
namespace Pinboard10
{
    /// <summary>
    /// An main page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    // MainPage class
    public sealed partial class MainPage : Page
    {
        // MainPage
        public MainPage()
        {
            this.InitializeComponent();

            BottomBar.Closed += BottomBarClosed;

        }//MainPage end


        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>

        // OnNavigatedTo
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            PinboardApiWrapper api = new PinboardApiWrapper();

            this.DataContext = new MainPageViewModel(api);

        }//OnNavigatedTo end


        // ButtonClick
        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            HyperlinkButton button = sender as HyperlinkButton;

            object thing = button.Content;
            
            this.Frame.Navigate(typeof(TagPosts), thing);

        }//ButtonClick end


        // TagSelected
        private void TagSelected(object sender, SelectionChangedEventArgs e)
        {
            if (TagListView.SelectedItem != null)
            {
                BottomBar.IsOpen = true;
            }

        }//TagSelected end


        // BottomBarClosed
        private void BottomBarClosed(object sender, object e)
        {
            TagListView.SelectedItem = null;

        }//BottomBarClosed end


        // AppBar_RenameButton_Click
        private void AppBar_RenameButton_Click(object sender, RoutedEventArgs e)
        {
            Tag selectedTag = TagListView.SelectedItem as Tag;

            if (selectedTag != null)
            {
                TagName.Text = selectedTag.Name;
            }
            else
            {
                // TODO: No Selected Tag popup
            }

        }//AppBar_RenameButton_Click end


        /*
        // RenameButton_Click
        private void RenameButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO
        }//RenameButton_Click end
        */

    }//class end

}//namespace end