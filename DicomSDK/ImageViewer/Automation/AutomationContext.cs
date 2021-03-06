﻿#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using ClearCanvas.Common;

namespace ClearCanvas.ImageViewer.Automation
{
    [ExtensionPoint]
    public sealed class AutomationExtensionPoint<T> : ExtensionPoint<T>
    {
    }

    public interface IAutomationContext
    {
        IImageBox SelectedImageBox { get; }
        ITile SelectedTile { get; }
    }

    public class AutomationContext : IAutomationContext
    {
        public static IAutomationContext Current { get; internal set; }

        private readonly IImageViewer _viewer;

        internal AutomationContext(IImageViewer viewer)
        {
            _viewer = viewer;
        }

        #region IContext Members

        public IWorkspaceLayout WorkspaceLayoutService { get { return null; } }
        public IDisplaySetLayout DisplaySetLayoutService { get { return null; } }
        public IStack StackService { get { return null; } }

        public IImageBox SelectedImageBox { get { return _viewer.SelectedImageBox; } }
        public ITile SelectedTile { get { return _viewer.SelectedTile; } }

        #endregion
    }
}
