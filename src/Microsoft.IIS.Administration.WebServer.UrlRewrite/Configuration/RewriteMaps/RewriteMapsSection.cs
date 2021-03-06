// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace Microsoft.IIS.Administration.WebServer.UrlRewrite
{
    using Web.Administration;

    sealed class RewriteMapsSection : ConfigurationSection {
        
        private RewriteMapCollection _rewriteMaps;
        
        public RewriteMapCollection RewriteMaps {
            get {
                if ((this._rewriteMaps == null)) {
                    this._rewriteMaps = ((RewriteMapCollection)(base.GetCollection(typeof(RewriteMapCollection))));
                }
                return this._rewriteMaps;
            }
        }
    }
}

