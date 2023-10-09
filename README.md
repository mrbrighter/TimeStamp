# TimeStamp GitLab Repository Documentation

## Overview

This GitLab repository contains a Windows Registry configuration file and a C# program that allows users to modify file or folder creation dates by right-clicking on them in the Windows File Explorer. The repository is organized as follows:

### Windows Registry Configuration

**Description**

The Windows Registry configuration file (`TimeStamp.reg`) in this repository adds context menu entries to the Windows File Explorer. When a user right-clicks on a file or folder, they can select the "Set Date" option to modify its creation date.

**Configuration**

```plaintext
Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\Directory\shell\TimeStamp]
@="Set Date"

[HKEY_CLASSES_ROOT\Directory\shell\TimeStamp\command]
@="\"D:\\TimeStamp\\TimeStamp.exe\" \"%V\""

[HKEY_CLASSES_ROOT\*\shell\TimeStamp]
@="Set Date"

[HKEY_CLASSES_ROOT\*\shell\TimeStamp\command]
@="\"D:\\TimeStamp\\TimeStamp.exe\" \"%V\""
```plaintext
To apply this configuration, double-click the TimeStamp.reg file, and Windows will add the context menu entries.

C# Program
Description

The C# program (TimeStamp.exe) in this repository is responsible for setting the creation date of files and folders. It takes command line arguments to identify the target item (file or folder) and the desired date and time for modification.

Features

Accepts command line arguments for specifying the target item and date.
Provides a graphical user interface (GUI) to input the date and time.
Handles Enter and Escape keys for ease of use.
Displays tooltips with item information.
Error handling for file and directory detection.
Usage

Start the program with the following command:

plaintext
Copy code
TimeStamp.exe "C:\path\to\file-or-folder"
Replace "C:\path\to\file-or-folder" with the path to the file or folder you want to modify.

Use the GUI to select the desired date and time.

Click the "Set" button to modify the creation date.
