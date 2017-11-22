﻿using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace TramlineFive.Common.ViewModels.Locator
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<VirtualTablesViewModel>();
            SimpleIoc.Default.Register<HistoryViewModel>();
        }

        public VirtualTablesViewModel VirtualTablesViewModel => SimpleIoc.Default.GetInstance<VirtualTablesViewModel>();
        public HistoryViewModel HistoryViewModel => SimpleIoc.Default.GetInstance<HistoryViewModel>();

    }
}
