using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    public class BasePage : UserControl
    {

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private object mViewModel;


        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;
        public float SlideSeconds { get; set; } = 0.4f;
        public bool ShouldAnimateOut { get; set; }

        public BasePage()
        {
            if (DesignerProperties.GetIsInDesignMode(this))
                return;

            // If we are animating in, hide to begin with
            if (PageLoadAnimation != PageAnimation.None)
                Visibility = Visibility.Collapsed;

            // Listen out for the page loading
            Loaded += BasePage_LoadedAsync;
        }

        private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
        {
            if (ShouldAnimateOut)
                // Animate out the page
                await AnimateOutAsync();
            // Otherwise...
            else
                // Animate the page in
                await AnimateInAsync();
        }

        public async Task AnimateInAsync()
        {
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    await this.SlideAndFadeInAsync(AnimationSlideInDirection.Right, false, SlideSeconds, size: (int)Application.Current.MainWindow.Width);
                    break;

            }
        }

        public async Task AnimateOutAsync()
        {
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {

                case PageAnimation.SlideAndFadeOutToLeft:

                    await this.SlideAndFadeOutAsync(AnimationSlideInDirection.Left, SlideSeconds);

                    break;
            }
        }
    }

    public class BasePage<VM> : BasePage where VM : ViewModel, new()
    {
        private VM mViewModel;

        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                if (mViewModel == value)
                    return;

                mViewModel = value;

                this.DataContext = mViewModel;
            }
        }

        public BasePage() : base()
        {

            ViewModel = new VM();
        }



    }
}
