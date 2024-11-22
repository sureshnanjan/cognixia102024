using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ITinyMCEEditor
    {
        void InitializeEditor(string iframeId);

        // Get the content from the TinyMCE editor
        string GetContent();

        // Set the content of the TinyMCE editor
        void SetContent(string content);

        // Clear the content inside the TinyMCE editor
        void ClearContent();

        // Get the iframe element containing the editor (this can be useful for debugging or UI interaction)
        object GetEditorIframe();
    }
}
