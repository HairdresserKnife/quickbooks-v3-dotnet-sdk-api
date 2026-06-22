////********************************************************************
// <copyright file="Connect.cs" company="Intuit">
//     Copyright (c) Intuit. All rights reserved.
// </copyright>
// <summary>Class genarated by extensiblity tempalte for Addin.This provides object for implementing addin.</summary>
////********************************************************************

namespace IntuitAnyWhereAddin
{
    using System;
    using EnvDTE80;
    using Extensibility;

    /// <summary>
    /// Class genarated by extensiblity tempalte for Addin.This provides object for implementing addin.
    /// </summary>
    /// <seealso class="IDTExtensibility2"/>
    [System.Runtime.InteropServices.ComVisible(true)]
    public class Connect : IDTExtensibility2
    {
        /// <summary>
        /// variable to stroe referecne of visual studio DTE object
        /// </summary>
        private DTE2 visualStudio;

        /// <summary>
        /// member varible to stroe referecne of MenuUtil object
        /// </summary>
        private MenuUtil intuitAnywhereMenuUtil;

        /// <summary>
        /// Initializes a new instance of the Connect class.
        /// Implements the constructor for the Add-in object.
        /// Place your initialization code within this method.
        /// </summary>
        public Connect()
        {
        }

        /// <summary>
        /// Implements the OnConnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being loaded.
        /// </summary>
        /// <param name="Application">Root object of the host application.</param>
        /// <param name="ConnectMode">Describes how the Add-in is being loaded.</param>
        /// <param name="AddInInst">Object representing this Add-in.</param>
        /// <param name="custom"> Array of parameters that are host application specific.</param>
        /// <seealso class='IDTExtensibility2' />
        public void OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
        {
            this.visualStudio = (DTE2)Application;
            ////m_AddIn = (AddIn)AddInInst;
        }

        /// <summary>
        /// Implements the OnDisconnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being unloaded.
        /// </summary>
        /// <param name="RemoveMode">Describes how the Add-in is being unloaded.</param>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        /// <seealso class="IDTExtensibility2"/>
        public void OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
        {
        }

        /// <summary>
        /// Implements the OnAddInsUpdate method of the IDTExtensibility2 interface. Receives notification when the collection of Add-ins has changed.
        /// </summary>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        /// <seealso class="IDTExtensibility2"/>
        public void OnAddInsUpdate(ref Array custom)
        {
        }

        /// <summary>
        /// Implements the OnStartupComplete method of the IDTExtensibility2 interface. Receives notification that the host application has completed loading.
        /// </summary>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        /// <seealso class="IDTExtensibility2"/>
        public void OnStartupComplete(ref Array custom)
        {
            this.intuitAnywhereMenuUtil = new MenuUtil(this.visualStudio);
           this.intuitAnywhereMenuUtil.ConstructIntuitAnywhereMenus();
        }

        /// <summary>
        /// Implements the OnBeginShutdown method of the IDTExtensibility2 interface. Receives notification that the host application is being unloaded.
        /// </summary>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        /// <seealso class="IDTExtensibility2"/>
        public void OnBeginShutdown(ref Array custom)
        {
            this.intuitAnywhereMenuUtil = null;
        }
    }
}
