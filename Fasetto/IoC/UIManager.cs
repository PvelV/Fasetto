using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto.Word
{
    public class UIManager : IUIManager
    {
        public Task ShowMessage(MessageBoxDialogViewModel viewModel)
        {
            // Create a task completion source
            var tcs = new TaskCompletionSource<bool>();

            // Run on UI thread
            Application.Current.Dispatcher.Invoke(async () =>
            {
                try
                {
                    // Show the dialog box
                    await new DialogMessageBox().ShowDialog(viewModel);
                }
                finally
                {
                    // Flag we are done
                    tcs.SetResult(true);
                }
            });

            // Return the task once complete
            return tcs.Task;
        }

      
    }
}
