using Fasetto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto.ViewModels
{
    public class WindowViewModel : ViewModel
    {

        #region Private Members

        private Window mWindow;
        private int mOuterMarginSize = 10;
        private int mWindowRadius = 10;


        #endregion

        #region Public Properties

        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// Size of the resize border around the window, taking into account the outer margin
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize { get { return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize; } }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius { get { return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius; } }

        /// <summary>
        /// The radius of the corners
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        #endregion

        #region Constructors

        public WindowViewModel(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) => 
            {
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
        }

        #endregion


    }
}
