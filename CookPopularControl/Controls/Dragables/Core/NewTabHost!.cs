﻿using CookPopularControl.Communal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



/*
 * Copyright (c) 2021 All Rights Reserved.
 * Description：NewTabHost
 * Author： Chance_写代码的厨子
 * Create Time：2021-08-11 17:40:28
 */
namespace CookPopularControl.Controls.Dragables.Core
{
    public class NewTabHost<TElement> : INewTabHost<TElement> where TElement : UIElement
    {
        private readonly TElement _container;
        private readonly DragableTabControl _tabableControl;

        public NewTabHost(TElement container, DragableTabControl tabableControl)
        {
            if (container == null) throw new ArgumentNullException("container");
            if (tabableControl == null) throw new ArgumentNullException("tabablzControl");

            _container = container;
            _tabableControl = tabableControl;
        }

        public TElement Container
        {
            get { return _container; }
        }

        public DragableTabControl DragableTabControl
        {
            get { return _tabableControl; }
        }
    }
}