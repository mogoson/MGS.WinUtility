[TOC]

# MGS.WinUtility

## Summary

- Windows utility for unity project develop.

## Environment

- Unity 5.0 or above.
- .Net Framework 3.5 or above.

## Platform

- Windows

## Module

### NetworkUtility

  ```C#
  //Network connect state.
  var state = NetworkUtility.GetNetworkConnectState();
  ```

### ComdlgUtility

  ```C#
  //string title, string directory, string filter.
  var selectFile = ComdlgUtility.OpenFileDialog("Open File", workDir, "Text(*.txt)\0*.txt");
  
  //string title, string directory, string defaultName, string filter.
  var saveFile = ComdlgUtility.SaveFileDialog("Save File", workDir, fileName, "Text(*.txt)\0*.txt");
  
  //string title.
  var folder = ComdlgUtility.OpenFolderDialog("Open Folder");
  ```

### ExplorerUtility

  ```C#
  //string path, bool select = true, bool eMode = true
  ExplorerUtility.Show(workDir, false);
  ```

## Demo

- Demos in the path "MGS.Packages/WinUtility/Demo/" provide reference to you.

## Source

- https://github.com/mogoson/MGS.WinUtility.

------

Copyright © 2021 Mogoson.	mogoson@outlook.com