﻿using Shapeshifter.Core.Data;
using Shapeshifter.Core.Factories.Interfaces;
using Shapeshifter.UserInterface.WindowsDesktop.Controls.Clipboard.Designer.Facades;
using Shapeshifter.UserInterface.WindowsDesktop.Properties;
using System.Diagnostics.CodeAnalysis;

namespace Shapeshifter.UserInterface.WindowsDesktop.Controls.Clipboard.Designer.Factories
{
    [ExcludeFromCodeCoverage]
    class DesignerTextDataSourceService : IDataSourceService
    {
        public IDataSource GetDataSource()
        {
            return new DesignerDataSourceFacade()
            {
                Text = "Skype",
                Icon = Resources.TextDataSourceIcon
            };
        }
    }
}
