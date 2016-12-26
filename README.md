# ConfirmationButton

[![Join the chat at https://gitter.im/ConfirmationButton/Lobby](https://badges.gitter.im/ConfirmationButton/Lobby.svg)](https://gitter.im/ConfirmationButton/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
***
A `ConfirmationButton` for Windows Forms applications

`ConfirmationButton` is a simple, customizable button that forces the user to confirm an action to prevent unintended results. Such as when deleting sensitive or important information or files, accepting terms and conditions or privacy policies, etc. The `ConfirmationButton` can also behave as a regular button.

This button is customizable.

In order to customize the appearance of this button, simply add it to your form, open up the Properties pane and change the `BackgroundColor`, `HighlightColor`, `ActiveColor`, `BorderColor`, `ConfirmedBackgroundColor`, `ConfirmedBorderColor`, `Separator` (Size), et al. to your liking.

If you would like this button to behave as a Confirmation button, you must set its `RequiresConfirmation` property to `true` - in the Properties pane, or from within your own code.

See the images below for the different states of ConfirmationButton:

![](http://i.imgur.com/zI4KiMc.png)
![](http://i.imgur.com/jT0XFUo.png)
![](http://i.imgur.com/CXn7onp.png)

-

Note:
If you are using the button to attain Agreement or Confirmation, you must handle the `Confirmed` event. You can do this from within the Properties pane or from within your code.

### Contributions:
Contributions are greatly appreciated and encouraged. When contributing, make sure to push to the Development branch. Once your changes have been approved, then will be merged with master.
