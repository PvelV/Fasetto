using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    public class BasePage<VM> : Page where VM : ViewModel, new()
    {
        private VM mViewModel;

        public bool ShouldAnimateOut { get; set; }

        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        public float SlideSeconds { get; set; } = 0.8f;

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

        public BasePage()
        {
            if (PageLoadAnimation != PageAnimation.None)
            {
                Visibility = Visibility.Collapsed;
            }
            Loaded += BasePage_LoadedAsync;

            ViewModel = new VM();
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

        private async Task AnimateInAsync()
        {
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    await this.SlideAndFadeInFromRightAsync(SlideSeconds);

                    break;


                case PageAnimation.SlideAndFadeOutToLeft:

                    break;
            }
        }

        private async Task AnimateOutAsync()
        {
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:


                    break;


                case PageAnimation.SlideAndFadeOutToLeft:

                    await this.SlideAndFadeOutToLeftAsync(SlideSeconds);

                    break;
            }
        }

    }
}
