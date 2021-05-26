
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientPage : ContentPage
    {
        public PatientPage()
        {
            InitializeComponent();
            this.BindingContext = this;

        }
        public ObservableCollection<Medical> MyMedical { get => GetMedical(); }

        private ObservableCollection<Medical> GetMedical()
        {
            return new ObservableCollection<Medical>
            {
                new Medical { Name = "Hari", Color = "#B96CBD",
                    Patientdetails = new ObservableCollection<Patient>{ new Patient { WardNo = 120, Time = "07:30" } } }, 

                new Medical { Name = "Bala ",  Color = "#49A24D", 
                    Patientdetails = new ObservableCollection<Patient>{ new Patient { WardNo = 143, Time = "08:30" } } },

                new Medical { Name = "Balaji", Color = "#FDA838", 
                    Patientdetails = new ObservableCollection<Patient>{ new Patient { WardNo = 34, Time = "09:00" } } },

                new Medical { Name = "Karthi", Color = "#F75355",
                    Patientdetails = new ObservableCollection<Patient>{ new Patient { WardNo = 78, Time = "11:50" } } }, 

                new Medical { Name = "John", Color = "#00C6AE",
                    Patientdetails = new ObservableCollection<Patient>{ new Patient { WardNo = 234, Time = "01:20" } } },

                new Medical { Name = "Peter", Color = "#455399",
                    Patientdetails = new ObservableCollection<Patient>{ new Patient { WardNo = 21, Time = "02:00" } } }, 
            };
        }
    }
    public class Medical
    {
        public string Name { get; set; }
        
        public string Color { get; set; }
        public ObservableCollection<Patient> Patientdetails { get; internal set; }
    }

    public class Patient
    {
        public int WardNo { get; set; }
        public string Time { get; set; }
    }



}
      

    

