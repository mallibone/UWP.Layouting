using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace UWP.Layouting.ViewModel
{
    internal class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //if (ViewModelBase.IsInDesignModeStatic)
            //{
            //}
            //else
            //{
            //}

            SimpleIoc.Default.Register<ResponsiveLayoutViewModel>();
            //SimpleIoc.Default.Register<PersonDetailViewModel>();
        }

        public ResponsiveLayoutViewModel ResponsiveLayout => SimpleIoc.Default.GetInstance<ResponsiveLayoutViewModel>();
    }
}
