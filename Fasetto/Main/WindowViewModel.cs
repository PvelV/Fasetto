using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word
{
    public class WindowViewModel : ViewModel
    {

        #region Private Members

        private Window mWindow;
        private int mOuterMarginSize = 10;
        private int mWindowRadius = 10;


        #endregion

        #region Public Properties


        public double WindowMinWidth { get; set; } = 800;
        public double WindowMinHeight { get; set; } = 500;
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

        public int TitleHeight { get; set; } = 42;
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

        #endregion

        #region Commands

        public Command MinimizeCommand { get; }
        public Command MaximizeCommand { get; }
        public Command CloseCommand { get; }

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

            MinimizeCommand = new Command(()=> mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new Command(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new Command(() => mWindow.Close());

            var resizer = new WindowResizer(mWindow);
        }
        public WindowViewModel()
        {

        }

        #endregion

    }
}
