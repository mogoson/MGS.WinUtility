[TOC]

﻿# MGS.WinLibrary.dll

## Summary

- DllImport methods of Windows library.

## Environment

- .Net Framework 3.5 or above.

## Dependence

- System.dll

## Implemented

- Comdlg32.

  ```C#
  public sealed class Comdlg32{}
  public class OpenFileName{}
  public sealed class OFNFlags{}
  public sealed class OFNFlagsEx{}
  ```

- Shell32.

  ```C#
  public sealed class Shell32{}
  public class BrowseInfo{}
  public sealed class BIFlags{}
  ```

- Wininet.

  ```C#
  public sealed class Wininet{}
  public sealed class InetFlags{}
  ```

------

[Previous](../../README.md)

------

Copyright © 2021 Mogoson.	mogoson@outlook.com