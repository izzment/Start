
const string dirname = "C:\\Users\\HP\\Desktop\\Start\\Files\\Challenge\\FileCollection";
const string filename = "TotalCount.txt";


int docTotal = 0;
int excelTotal = 0;
int pptTotal = 0;

if(!Directory.Exists(dirname)){
    Directory.CreateDirectory(dirname);
} else {
    List<string> thefiles = new List<string>(Directory.EnumerateFiles(dirname));
    foreach (string dir in thefiles){
        string ext = Path.GetExtension(dir);

        switch (ext){
            case ".docx":
                docTotal += 1;
                break;
            case ".xlsx":
                excelTotal += 1;
                break;
            case ".pptx":
                pptTotal += 1;
                break;
            default:
                Console.WriteLine("WHOOPS");
                break;
        }
    }
    if (!File.Exists(filename)){
        using (StreamWriter sw = File.CreateText(filename)){
            sw.WriteLine($"There are {docTotal} word documents, {excelTotal} excel documents, and {pptTotal} powerpoint documents in this directory.");
        }
    }
    try {
        FileInfo fi = new FileInfo(filename);
        Console.WriteLine($"{fi.Directory}");
    } catch (Exception e){
        Console.WriteLine($"Exception: {e}");
    }
}