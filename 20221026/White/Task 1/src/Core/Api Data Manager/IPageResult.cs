﻿using System.Text.Json.Serialization;

namespace White.Core
{
    internal interface IPageResult
    {
        /// <summary>
        /// Apidan kelgan resultlar soni
        /// </summary>
        public string TotalResults { get; set; }
        /// <summary>
        /// Apidan kelgan result holati
        /// </summary>

        public string Response { get; set; }
        /// <summary>
        /// Resultlari listi
        /// </summary>
        
        public List<Movie> Results { get; set; }
    }
}