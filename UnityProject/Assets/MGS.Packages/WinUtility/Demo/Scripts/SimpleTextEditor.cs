/*************************************************************************
 *  Copyright © 2019 Mogoson. All rights reserved.
 *------------------------------------------------------------------------
 *  File         :  SimpleTextEditor.cs
 *  Description  :  Null.
 *------------------------------------------------------------------------
 *  Author       :  Mogoson
 *  Version      :  0.1.0
 *  Date         :  9/8/2019
 *  Description  :  Initial development version.
 *************************************************************************/

using MGS.WinCommon.Utility;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.WinUtility.Demo
{
    public class SimpleTextEditor : MonoBehaviour
    {
        #region Field and Property
        public Button btn_New;
        public Button btn_Open;
        public Button btn_Save;
        public Button btn_Browse;
        public Button btn_Show;
        public Button btn_Exit;
        public InputField ipt_Content;

        protected string workDir = "c:\\";
        protected string currentFile = string.Empty;
        protected uint newFileNumber = 0;
        #endregion

        #region Protected Method
        protected virtual void Awake()
        {
            btn_New.onClick.AddListener(OnNewBtnClick);
            btn_Open.onClick.AddListener(OnOpenBtnClick);
            btn_Save.onClick.AddListener(OnSaveBtnClick);
            btn_Browse.onClick.AddListener(OnBrowseBtnClick);
            btn_Show.onClick.AddListener(OnShowBtnClick);
            btn_Exit.onClick.AddListener(OnExitBtnClick);
        }

        protected void OnNewBtnClick()
        {
            ipt_Content.text = string.Empty;
            currentFile = string.Empty;
            newFileNumber++;
        }

        protected void OnOpenBtnClick()
        {
            var selectFile = ComdlgUtility.OpenFileDialog("Open File", workDir, "Text(*.txt)\0*.txt");
            if (string.IsNullOrEmpty(selectFile))
            {
                return;
            }

            currentFile = selectFile;
            ipt_Content.text = File.ReadAllText(currentFile);
        }

        protected void OnSaveBtnClick()
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                var fileName = "New text";
                if (newFileNumber > 0)
                {
                    fileName += (" " + newFileNumber);
                }

                var saveFile = ComdlgUtility.SaveFileDialog("Save File", workDir, fileName, "Text(*.txt)\0*.txt");
                if (string.IsNullOrEmpty(saveFile))
                {
                    return;
                }
                currentFile = saveFile;
            }
            File.WriteAllText(currentFile, ipt_Content.text);
        }

        protected void OnBrowseBtnClick()
        {
            var folder = ComdlgUtility.OpenFolderDialog("Open Folder");
            if (!string.IsNullOrEmpty(folder))
            {
                workDir = folder;
            }
        }

        protected void OnShowBtnClick()
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                ExplorerUtility.Show(workDir, false);
            }
            else
            {
                ExplorerUtility.Show(currentFile);
            }
        }

        protected void OnExitBtnClick()
        {
            gameObject.SetActive(false);
        }
        #endregion
    }
}