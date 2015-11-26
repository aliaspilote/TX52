using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Forms.Model;
using Modelisator.Forms.View;
using Modelisator.MyGraphSharp;
using GraphSharp.Controls;
using Modelisator.Model;
using QuickGraph;

namespace Modelisator.Forms.ViewModel
{
    internal class EspaceTravail_Graph_ViewModel
    {

        public EspaceTravail_Graph_ViewModel()
        {
        }

        public EspaceTravail_Graph_ViewModel(Contexte ctx)
        {
            View = new EspaceTravail_Graph_View();
            Model = new EspaceTravail_Graph_Model(ctx);
            SetupGraphForm();
        }

        public EspaceTravail_Graph_View View { get; private set; }
        public EspaceTravail_Graph_Model Model { get; private set; }

        protected void SetupGraphForm()
        {
            MainWindowViewModel m = new MainWindowViewModel();
            View.DataContext = m;


        }
    }
}
