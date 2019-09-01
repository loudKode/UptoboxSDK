using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UptoboxSDK.JSON;

namespace UptoboxSDK
{
	public interface IClient
	{
		Task<JSON_ListPublicFiles> ListPublicFiles(string DestinationFolderID, string DestinationFolderHash, Uutilities.OrderByEnum OrderBy, Uutilities.SortEnum Sort, int Limit, int OffSet);

		Task<JSON_GetVideoQuality> GetVideoQuality(int DestinationVideoFileID);

		Task<JSON_Stats> Stats(int PageNum);

		Task<bool> UnLockFile_Multiple(Dictionary<string, string> DestinationFileID_Name);

		Task<bool> LockFile_Multiple(List<string> DestinationFileIDList, string Password);

		Task<JSON_StorageInfo> StorageInfo();

		Task<JSON_ListAllFiles> ListAllFiles();

		Task<JSON_ListCurrentfolder> GetFolderMetadata(string DestinationFolderPath);

		Task<JSON_GetFolderContains> GetFolderContains(string DestinationFolderID);

		Task<bool> DeleteFolders(List<string> DestinationFolderIDs);

		Task<bool> RemoteUpload(List<string> Urls);

		Task<bool> DeleteFolder(string DestinationFolderID);

		Task<bool> DeleteFiles(List<string> DestinationFileIDs);

		Task<bool> MoveFiles(List<string> SourceFileIDs, string DestinationFolderID);

		Task<bool> CopyFiles(List<string> SourceFileIDs, string DestinationFolderID);

		Task<bool> RenameFolder(string DestinationFolderID, string NewName);

		Task<bool> CreateNewFolder(string DestinationFolderPath, string FolderName);

		Task<bool> SetPrivate_Multiple(List<string> DestinationFileIDList);

		Task<bool> SetPublic_Multiple(List<string> DestinationFileIDList);

		Task<bool> UnLockFile(string DestinationFileID, string DestinationFileName);

		Task<bool> LockFile(string DestinationFileID, string Password);

		Task<bool> RenameFile(string DestinationFileID, string NewName);

		Task<bool> SetPrivate(string DestinationFileID);

		Task<bool> SetPublic(string DestinationFileID);

		Task<bool> SecurityLock(bool Enable);

		Task<JSON_UserInfo> UserInfo();

		Task<JSON_GenerateDownloadLink> GenerateDownloadLink(string DestinationFileID, IProgress<ReportStatus> ReportCls = null, CancellationToken token = default(CancellationToken));

		Task<JSON_List> List(string DestinationFolderPath, Uutilities.OrderByEnum OrderBy, Uutilities.SortEnum Sort, int Limit, int OffSet);

		Task<JSON_Upload> Upload(object FileToUpload, UClient.UploadTypes UploadType, string FileName, string DestinationFolderID, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, CancellationToken token = default(CancellationToken));

		Task DownloadFile(string FileUrl, string FileSaveDir, string FileName, IProgress<ReportStatus> ReportCls = null, ProxyConfig _proxi = null, int TimeOut = 60, CancellationToken token = default(CancellationToken));

		Task<JSON_List> Search(string DestinationFolderPath, string SearchKeyword, Uutilities.OrderByEnum OrderBy, Uutilities.SortEnum Sort, int Limit, int OffSet);
	}
}
