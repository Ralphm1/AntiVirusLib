using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AntiVirus;

namespace AntiVirusLib
{
    public class AVChecker
    {
        /// <summary>
        /// Scans the named file, in the file path.
        /// If the file is found to contain a virus, the file will be removed
        /// and a string response will be provided.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>String.</returns>
        public String ScanFile(String filePath)
        {
            Scanner scanner = new Scanner();
            String result = scanner.ScanAndClean(filePath).ToString();

            return result;
        }

        /// <summary>
        /// Scans the named file, in the file path.
        /// If the file is found to contain a virus, the file will be removed
        /// and a numeric (enumerated) response will be provided.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>ScanResult (an enumerated response).</returns>
        public ScanResult ScanFileEnum(String filePath)
        {
            Scanner scanner = new Scanner();
            ScanResult result = scanner.ScanAndClean(filePath);

            return result;
        }

    }
}
