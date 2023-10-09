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
