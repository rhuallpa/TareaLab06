using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TareaLab06

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<StudentGroup> studentGroups = new List<StudentGroup>
        {
            new StudentGroup("Sección A", new List<Student>
            {
                new Student { Name = "Rebeca", LastName = "Huallpa" , Age = 20 },
                new Student { Name = "Valeria", LastName = "Centeno", Age = 22 },
                new Student { Name = "Jesus", LastName = "Gomez", Age = 23 },
                new Student { Name = "Maria", LastName = "Dominguez", Age = 18 },
                new Student { Name = "Pedro", LastName = "Guerrero", Age = 18 }
            }),
            new StudentGroup("Sección B", new List<Student>
            {
                new Student { Name = "Jaime", LastName = "Farfan" , Age = 18 },
                new Student { Name = "Linder", LastName = "Torres", Age = 20 },
                new Student { Name = "Bellasol", LastName = "Magna", Age = 19  },
                new Student { Name = "Romina", LastName = "Rodríguez", Age = 18 },
                new Student { Name = "Soledad", LastName = "Jimenez", Age = 17 },
            }),
            new StudentGroup("Sección C", new List<Student>
            {
                new Student { Name = "Carolima", LastName = "Barreto", Age = 24 },
                new Student { Name = "Paola", LastName = "Ortega", Age = 19 },
                new Student { Name = "Rosalinda", LastName = "Perez", Age = 20 },
                new Student { Name = "Jose Antonio", LastName = "Gallardo", Age = 20 },
                new Student { Name = "Miguel", LastName = "Duran", Age = 22 }
            }),
            new StudentGroup("Seccion D", new List<Student>
            {
                new Student { Name = "Santiago", LastName = "Sánchez", Age = 18 },
                new Student { Name = "Florinda", LastName = "Ramos", Age = 22 },
                new Student { Name = "Victoria", LastName = "Vargas", Age = 21 },
                new Student { Name = "Paulina", LastName = "Martinez", Age = 19 },
                new Student { Name = "Leonardo", LastName = "Garcia", Age = 20 }
            })
        };

            listView.ItemsSource = studentGroups;
        }

    }
}
