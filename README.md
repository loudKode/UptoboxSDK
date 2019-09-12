# UptoboxSDK
.NET API Library for uptobox.com

`Download:`[https://github.com/loudKode/UptoboxSDK/releases](https://github.com/loudKode/UptoboxSDK/releases)<br>
`NuGet:`
[![NuGet](https://img.shields.io/nuget/v/DeQmaTech.UptoboxSDK.svg?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DeQmaTech.UptoboxSDK)<br>

# Functions:
* CopyFiles
* CreateNewFolder
* DeleteFiles
* DeleteFolder
* DeleteFolders
* DownloadFile
* GenerateDownloadLink
* GetFolderContains
* GetFolderMetadata
* GetVideoQuality
* List
* ListAllFiles
* ListPublicFiles
* LockFile
* LockFile_Multiple
* MoveFiles
* RemoteUpload
* RenameFile
* RenameFolder
* Search
* SecurityLock
* SetPrivate
* SetPrivate_Multiple
* SetPublic
* SetPublic_Multiple
* Stats
* StorageInfo
* UnLockFile
* UnLockFile_Multiple
* Upload
* UserInfo


# Example:
**get access token**
```vb.net
 Dim tkn= Await UptoboxSDK.GetToken.Get_Token("xxxxx", "xxxxxx")
```

**set client**
```vb.net
Dim UTBclient As UptoboxSDK.IClient = New UptoboxSDK.UClient("token", "sess_id")
```

**list files / folders**
```vb.net
        Dim RSLT = Await UTBclient .List(TextBox2.Text, UptoboxSDK.Uutilities.OrderByEnum.file_size, UptoboxSDK.Uutilities.SortEnum.DESC, 20, 0)
        For Each itm In RSLT.data.FilesList
            DataGridView1.Rows.Add(itm.file_name, itm.file_code, itm.file_size)
        Next
```
