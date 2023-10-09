# TimeStamp Tool

## Overview
This GitLab repository contains a Windows Registry configuration file and a C# program that allows users to modify file or folder creation dates by right-clicking on them in the Windows File Explorer. The repository is organized as follows:

- Windows Registry Configuration: A .reg file that adds context menu entries to the Windows File Explorer.
- C# Program: A C# program that performs the date modification when triggered from the context menu.

## Windows Registry Configuration

###Description
The Windows Registry configuration file (TimeStamp.reg) in this repository adds context menu entries to the Windows File Explorer. When a user right-clicks on a file or folder, they can select the "Set Date" option to modify its creation date.
The binary path should be observed or adjusted here.

Configuration
```
Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\Directory\shell\TimeStamp]
@="Set Date"

[HKEY_CLASSES_ROOT\Directory\shell\TimeStamp\command]
@="\"D:\\TimeStamp\\TimeStamp.exe\" \"%V\""

[HKEY_CLASSES_ROOT\*\shell\TimeStamp]
@="Set Date"

[HKEY_CLASSES_ROOT\*\shell\TimeStamp\command]
@="\"D:\\TimeStamp\\TimeStamp.exe\" \"%V\""
```



## C# Program

### Description
The C# program (TimeStamp.exe) in this repository is responsible for setting the creation date of files and folders. It takes command line arguments to identify the target item (file or folder) and the desired date and time for modification.

### Features
- Accepts command line arguments for specifying the target item and date.
- Provides a graphical user interface (GUI) to input the date and time.
- Handles Enter and Escape keys for ease of use.
- Displays tooltips with item information.
- Error handling for file and directory detection.

### Usage
1. Start the program with the following command:
```
TimeStamp.exe "C:\path\to\file-or-folder"
```
Replace "C:\path\to\file-or-folder" with the path to the file or folder you want to modify.
2. Use the GUI to select the desired date and time.
3. Click the "Set" button to modify the creation date.

### Requirements
- .NET Framework for running C# applications on Windows.
### Example Usage
```
TimeStamp.exe "C:\Example\File.txt"
```

### Important Notes
Be cautious when modifying creation dates, as it may affect the integrity of files or folders.
Always back up important data before using this tool.

##Conclusion
This GitLab repository provides a convenient way to modify file and folder creation dates in Windows File Explorer. Please use it responsibly and follow best practices for data management and backup.

For any issues or inquiries, please refer to the repository's issue tracker or contact the repository owner.

Thank you for using TimeStamp!
