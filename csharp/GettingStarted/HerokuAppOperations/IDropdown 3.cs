using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
   
        public interface IDropdown
        {
            /// <summary>
            /// Select an option in the dropdown by its visible text.
            /// </summary>
            /// <param name="optionText">The visible text of the option to select.</param>
            void SelectOptionByText(string optionText);

            /// <summary>
            /// Get the text of the currently selected option in the dropdown.
            /// </summary>
            /// <returns>The text of the selected option, or a message if no option is selected.</returns>
            string GetSelectedOptionText();

            /// <summary>
            /// Get the list of all available options' text in the dropdown.
            /// </summary>
            /// <returns>A list of strings representing the text of all options in the dropdown.</returns>
            List<string> GetAllOptionsText();
        }
    }


