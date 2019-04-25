﻿using DFC.Digital.Tools.Data.Interfaces;
using Microsoft.Extensions.Configuration;
using System;

namespace DFC.Digital.Tools.Core
{
    public class AppConfigConfigurationProvider : IConfigConfigurationProvider
    {
       // private readonly IConfiguration configuration;
        public AppConfigConfigurationProvider()
        {
           // this.configuration = configuration;
        }

        public void Add<T>(string key, T value)
        {
            throw new NotImplementedException();
        }

        public T GetConfig<T>(string key)
        {
            // var value = this.configuration[key];
            var value = key;

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public T GetConfig<T>(string key, T defaultValue)
        {
            // var value = this.configuration[key];
            var value = key;

            return value == null ? defaultValue : (T)Convert.ChangeType(value, typeof(T));
        }
    }
}