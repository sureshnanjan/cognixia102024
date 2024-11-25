/*
 
Licensed to the Software Freedom Conservancy (SFC) under one
or more contributor license agreements. See the NOTICE file
distributed with this work for additional information
regarding copyright ownership. The SFC licenses this file
to you under the Apache License, Version 2.0 (the
"License"); you may not use this file except in compliance
with the License. You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0 
Unless required by applicable law or agreed to in writing,
software distributed under the License is distributed on an
"AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
KIND, either express or implied. See the License for the
specific language governing permissions and limitations
under the License.
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerokuAppOperations;


namespace HerokuAppWebdriverAdapter
{
    public class TinyMCEEditor: ITinyMCEEditor
    {
        private WebBrowser _webBrowser;  // Assuming WebBrowser control for handling iframe
        private string _iframeId;

        // Constructor to initialize the WebBrowser control
        public TinyMCEEditor(WebBrowser webBrowser)
        {
            _webBrowser = webBrowser;
            _webBrowser.ScriptErrorsSuppressed = true; // Suppress script errors to ensure smooth operation
        }

        // Initialize the TinyMCE editor inside the iframe
        public void InitializeEditor(string iframeId)
        {
            _iframeId = iframeId;
            string script = @"
            var iframe = document.getElementById('" + iframeId + @"');
            if (iframe) {
                tinymce.init({
                    selector: 'iframe#' + '" + iframeId + @"' + ' iframe',
                    height: 300,
                    menubar: false
                });
            }";

            // Execute the JavaScript to initialize TinyMCE in the iframe
            _webBrowser.Document.InvokeScript("execScript", new object[] { script, "JavaScript" });
        }

        // Get the content of the TinyMCE editor
        public string GetContent()
        {
            string script = @"
            var iframe = document.getElementById('" + _iframeId + @"');
            if (iframe) {
                return tinymce.get(iframe.contentWindow.document).getContent();
            }
            return '';";

            // Execute the script and get the content from TinyMCE
            return _webBrowser.Document.InvokeScript("eval", new object[] { script }) as string;
        }

        // Set the content of the TinyMCE editor
        public void SetContent(string content)
        {
            string script = @"
            var iframe = document.getElementById('" + _iframeId + @"');
            if (iframe) {
                tinymce.get(iframe.contentWindow.document).setContent('" + content + @"');
            }";

            // Execute the script to set the content of TinyMCE
            _webBrowser.Document.InvokeScript("execScript", new object[] { script, "JavaScript" });
        }

        // Clear the content inside the TinyMCE editor
        public void ClearContent()
        {
            SetContent(string.Empty); // Clears content by setting it to an empty string
        }

        // Get the iframe element containing the editor (if needed for debugging)
        public object GetEditorIframe()
        {
            return _webBrowser.Document.GetElementById(_iframeId); // Returning HtmlElement or similar object
        }
    }
}

