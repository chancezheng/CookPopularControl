﻿using CookPopularControl.Controls.Dragables;
using System.Windows;



/*
 * Copyright (c) 2021 All Rights Reserved.
 * Description：IInterLayoutClient
 * Author： Chance_写代码的厨子
 * Create Time：2021-08-12 08:55:14
 */
namespace CookPopularControl.Controls.Dragables
{
    /// <summary>
    /// Implementors should provide a mechanism to provide a new host control which contains a new <see cref="DragableTabControl"/>.
    /// </summary>
    public interface IInterLayoutClient
    {
        /// <summary>
        /// Provide a new host control and tab into which will be placed into a newly created layout branch.
        /// </summary>
        /// <param name="partition">Provides the partition where the drag operation was initiated.</param>
        /// <param name="source">The source control where a dragging operation was initiated.</param>
        /// <returns></returns>
        INewTabHost<UIElement> GetNewHost(object partition, DragableTabControl source);
    }
}
