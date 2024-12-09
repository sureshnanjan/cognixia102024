// --------------------------------------------------------------------------------------------------------------------
// © [Your Company Name], [Year]. All rights reserved.
// This code is the property of [Your Company Name] and is protected by copyright law. Unauthorized reproduction or
// distribution of this code, or any portion of it, may result in civil and criminal penalties and will be prosecuted
// to the maximum extent possible under the law.
// --------------------------------------------------------------------------------------------------------------------

// Interface that defines methods to switch between frames and get text from them.
public interface INestedFramesHandler
{
    void SwitchToTopFrame();         // Switch to the top frame.
    void SwitchToLeftFrame();        // Switch to the left frame within the top frame.
    void SwitchToMiddleFrame();      // Switch to the middle frame within the top frame.
    void SwitchToRightFrame();       // Switch to the right frame within the top frame.
    void SwitchToBottomFrame();      // Switch to the bottom frame.
    string GetTextFromCurrentFrame(); // Get text content from the current frame.
    void SwitchToDefaultContent();   // Switch back to the default content (main page).
}

