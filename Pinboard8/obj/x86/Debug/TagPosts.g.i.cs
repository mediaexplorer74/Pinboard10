﻿

#pragma checksum "C:\Users\Geraint\Documents\GitHub\Pinboard8\Pinboard8\TagPosts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF5AAD240E962ECA480F072D75EF44AC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pinboard8
{
    partial class TagPosts : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Page pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBar BottomBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton EditPostAppBarButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton DeletePostAppBarButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView PostsListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///TagPosts.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::Windows.UI.Xaml.Controls.Page)this.FindName("pageRoot");
            BottomBar = (global::Windows.UI.Xaml.Controls.AppBar)this.FindName("BottomBar");
            EditPostAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("EditPostAppBarButton");
            DeletePostAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("DeletePostAppBarButton");
            PostsListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("PostsListView");
        }
    }
}



