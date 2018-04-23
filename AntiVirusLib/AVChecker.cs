using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AntiVirus;

namespace AntiVirusLib
{
    public class AVChecker
    {
        public String ScanFile(String filePath)
        {
            Scanner scanner = new Scanner();
            String result = scanner.ScanAndClean(filePath).ToString();

            return result;
        }

        public ScanResult ScanFileEnum(String filePath)
        {
            Scanner scanner = new Scanner();
            ScanResult result = scanner.ScanAndClean(filePath);

            return result;
        }

    }
}
