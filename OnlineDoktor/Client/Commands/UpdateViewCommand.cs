using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Patient")
            {
                viewModel.SelectedViewModel = new PatientViewModel();
            }
            else if (parameter.ToString() == "Doctor")
            {
                viewModel.SelectedViewModel = new DoctorViewModel();
            }
            else if(parameter.ToString() == "Examination")
            {
                viewModel.SelectedViewModel = new ExaminationViewModel();
            } 
        }
    }
}
