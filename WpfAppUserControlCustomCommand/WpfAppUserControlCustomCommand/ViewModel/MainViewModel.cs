using GalaSoft.MvvmLight;

namespace WpfAppUserControlCustomCommand.ViewModel
{
    using System;
    using System.Windows.Input;

    using GalaSoft.MvvmLight.CommandWpf;

    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private Random rd;
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            rd = new Random();

            BtnCommand = new RelayCommand(
                () => { TempValue = rd.Next(0, 1000) / 10.0; });
        }

        private double _tempvalue;

        public double TempValue
        {
            get
            {
                return _tempvalue;
            }
            set
            {
                Set(ref _tempvalue, value);
            }
        }

        public ICommand BtnCommand { get; set; }
    }
}