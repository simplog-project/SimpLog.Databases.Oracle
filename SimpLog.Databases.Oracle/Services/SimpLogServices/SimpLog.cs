﻿using SimpLog.Databases.Oracle.Models;
using SimpLog.Databases.Oracle.Services.FileServices;

namespace SimpLog.Databases.Oracle.Services.SimpLogServices
{
    public class SimpLog
    {
        private FileService _fileService = new FileService();

        /// <summary>
        /// If there is no configuration set up in appsettings.json, log is enabled. If there is disabled from the
        /// configuration, take it in mind here.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="saveInDatabase"></param>
        /// <returns></returns>
        public async Task Trace(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Trace, saveInDatabase);

        public async Task Debug(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Debug, saveInDatabase);

        public async Task Info(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Info, saveInDatabase);
        
        public async Task Notice(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Notice, saveInDatabase);

        public async Task Warn(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Warn, saveInDatabase);

        public async Task Error(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Error, saveInDatabase);

        public async Task Fatal(string message, bool? saveInDatabase = true)
            => await _fileService.Save(message, LogType.Info, saveInDatabase);
    }
}