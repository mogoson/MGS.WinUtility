[TOC]

﻿# MGS.WinUtility.dll

## Summary

- Common utility code for Windows.

## Environment

- .Net Framework 3.5 or above.

## Dependence

- System.dll
- MGS.WinLibrary.dll

## Module

### Network

- Implemented

```C#
public enum NetworkConnState{}
public sealed class NetworkUtility{}
```

- Usage

```C#
//Network connect state.
var state = NetworkUtility.GetNetworkConnectState();
```

### Comdlg

- Implemented

```C#
public class ComdlgUtility{}
```

- Usage

```C#
//string title, string directory, string filter.
var selectFile = ComdlgUtility.OpenFileDialog("Open File", workDir, "Text(*.txt)\0*.txt");

//string title, string directory, string defaultName, string filter.
var saveFile = ComdlgUtility.SaveFileDialog("Save File", workDir, fileName, "Text(*.txt)\0*.txt");

//string title.
var folder = ComdlgUtility.OpenFolderDialog("Open Folder");
```

### Explorer

- Implemented

```C#
public sealed class ExplorerUtility{}
```

- Usage

```C#
//string path, bool select = true, bool eMode = true
ExplorerUtility.Show(workDir, false);
```

------

[Previous](../../README.md)

------

Copyright © 2021 Mogoson.	mogoson@outlook.com