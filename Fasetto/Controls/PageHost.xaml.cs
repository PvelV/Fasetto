using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {


        public BasePage CurrentPage
        {
            get { return (BasePage)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }


        public static readonly DependencyProperty CurrentPageProperty = DependencyProperty.Register(
            nameof(CurrentPage), typeof(BasePage), typeof(PageHost), 
                new UIPropertyMetadata(CurrentPagePropertyChanged));


        public ViewModel CurrentPageViewModel
        {
            get => (ViewModel)GetValue(CurrentPageViewModelProperty);
            set => SetValue(CurrentPageViewModelProperty, value);
        }

        /// <summary>
        /// Registers <see cref="CurrentPageViewModel"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageViewModelProperty = DependencyProperty.Register(
            nameof(CurrentPageViewModel),
                typeof(ViewModel), typeof(PageHost), new UIPropertyMetadata());

        public PageHost()
        {
            InitializeComponent();
        }

 

            private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            var oldPageContent = newPageFrame.Content;

            newPageFrame.Content = null;

            oldPageFrame.Content = oldPageContent;

            if (oldPageContent is BasePage oldPage)
            {
                oldPage.ShouldAnimateOut = true;

                Task.Delay((int)oldPage.SlideSeconds * 1000).ContinueWith((t) =>
                {
                    Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
                });
            }

            newPageFrame.Content = e.NewValue;


        }
    }
}
