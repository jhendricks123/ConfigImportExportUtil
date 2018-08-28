using System;

namespace ConfigImportExportUtil.Data
{
    internal class MicInfo
    {
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool RecordingEnabled { get; set; }

        public int ReadOnlyChannel { get; set; }
        public string ReadOnlyHardwareName { get; set; }
        public string ReadOnlyDriverName { get; set; }
        public int ReadOnlyDriverNumber { get; set; }
        public string ReadOnlyRecordingServer { get; set; }
        public Guid ReadOnlyId { get; set; }
    }
}