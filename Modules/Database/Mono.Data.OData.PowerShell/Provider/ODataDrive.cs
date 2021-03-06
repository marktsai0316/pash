/*
	Copyright (c) 2012 Code Owls LLC

	Permission is hereby granted, free of charge, to any person obtaining a copy 
	of this software and associated documentation files (the "Software"), to 
	deal in the Software without restriction, including without limitation the 
	rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
	sell copies of the Software, and to permit persons to whom the Software is 
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in 
	all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
	FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
	IN THE SOFTWARE. 
*/
using System;
using System.Linq;
using System.Management.Automation;
using System.Xml.Linq;
using Mono.Data.PowerShell.Provider;

namespace Mono.Data.OData.Provider
{
    public class ODataDrive : Mono.Data.PowerShell.Provider.Drive
    {
        private readonly Uri _oDataSourceUri;
        private XDocument _odataSourceDocument;
        private XDocument _odataMetadataDocument;

        public ODataDrive(Uri oDataSourceUri, PSDriveInfo driveInfo)
            : base(driveInfo)
        {
            _oDataSourceUri = oDataSourceUri;            
        }


        public XDocument ODataSourceDocument
        {
            get
            {
                if (null == _odataSourceDocument)
                {
                    _odataSourceDocument = LoadODataSourceUri();
                }
                return _odataSourceDocument;
            }
        }

        public XDocument Metadata
        {
            get
            {
                if (null == _odataMetadataDocument)
                {
                    _odataMetadataDocument= LoadODataMetadataUri();
                }
                return _odataMetadataDocument;
            }
        }

        public Uri ODataSourceUri
        {
            get { return _oDataSourceUri; }
        }

        public Uri ODataMetadataUri
        {
            get
            {
                var xmlBase = from attr in ODataSourceDocument.Descendants().Attributes(Names.XmlBase)
                              select attr.Value;

                var baseUri = new Uri(xmlBase.First());
                return new Uri(baseUri, "$metadata");
            }
        }

        private XDocument LoadODataSourceUri()
        {
            return XDocumentManager.Get(ODataSourceUri);            
        }

        private XDocument LoadODataMetadataUri()
        {
            return XDocumentManager.Get(ODataMetadataUri);
        }
    }
}
