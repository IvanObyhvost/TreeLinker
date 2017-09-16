
namespace TreeLinker.Resource
{
    public class ConstantName
    {
        public const string HrefPattern = @"((www\.|(http|https|ftp|news|file)+\:\/\/)[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)])";
        public const string RegexLattice = @"\#";
        public const string RegexAHref = @"<a\s+(?:[^>]*?\s+)?href=\""([^\""]*)";
        public const string RegexTitle = @"(?<=<title>)(.*)(?=</title>)";
        public const string RegexHttp = @"(www\.|(http|https|ftp|news|file)+\:\/\/)$";
        public const string XElementFolder = "folder";
        public const string FileName = "treeNodeXml";
        public const string XAttributeTitle = "title";
        public const string XElementXbel = "xbel";
        public const string XAttributeVersion = "version";
        public const string XAttributeVersionNumber = "1.0";
        public const char TrimChar = '"';

        public const string InvalidUrlMessage = "Invalid URL entered";
        public const string WaitMessage = "Please wait, building tree...";
        public const string DoneMessage = "Done";
        public const string SavedSuccessfullyMessage = "Saved successfully";

        public const int StartDepth = 0;
        public const int Index = 0;
    }
}
