﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModuleBase.cs" company="GoldenEagle.Desktop.Framwork development team">
//   Copyright (c) 2008 - 2012 GoldenEagle.Desktop.Framwork development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Microsoft.Practices.Prism.Modularity;
using GoldenEagle.Desktop.Framwork.Services;

namespace GoldenEagle.Desktop.Framwork.Modules
{


    /// <summary>
    /// Base class for all modules used by GoldenEagle.Desktop.Framwork.
    /// </summary>
    [Module]
    public abstract class ModuleBase : Catel.Modules.ModuleBase
    {
        /// <summary>
        /// The name of the home ribbon tab.
        /// </summary>
        public const string HomeRibbonTabName = "Home";

        /// <summary>
        /// The modules directory name.
        /// </summary>
        public const string ModulesDirectory = "Modules";

        /// <summary>
        /// Gets the license URL.
        /// <para />
        /// If this method returns an empty string, it is assumed the module has no license.
        /// </summary>
        /// <returns>The url of the license.</returns>
        public virtual string GetLicenseUrl()
        {
            return string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleBase"/> class.
        /// </summary>
        /// <param name="moduleName">Name of the module.</param>
        /// <exception cref="ArgumentException">The <paramref name="moduleName"/> is <c>null</c> or whitespace.</exception>
        protected ModuleBase(string moduleName) 
            : base(moduleName)
        {
            var ribbonService = GetService<IRibbonService>();
            InitializeRibbon(ribbonService);
        }

        /// <summary>
        /// Initializes the ribbon.
        /// <para />
        /// Use this method to hook up views to ribbon items.
        /// </summary>
        /// <param name="ribbonService">The ribbon service.</param>
        protected virtual void InitializeRibbon(IRibbonService ribbonService)
        {
            
        }
    }
}