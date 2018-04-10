﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Student.Common.Logic.Log
{
    public class Logger : ILogger
    {
        private readonly ILog _logger;

        public Logger(Type type)
        {
            _logger = LogManager.GetLogger(type);
        }
        public void Debug(object mensaje) => _logger.Debug(mensaje);

        public void Error(object mensaje) => _logger.Error(mensaje);

        public void Error(Exception ex)
        {
            _logger.Error($"Error{ex.GetType().Name} , {ex.Message} ,ruta {ex.StackTrace}",ex);
        }

        public void Info(object mensaje) => _logger.Info(mensaje);
    }
}
