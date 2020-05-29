using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Domain.Models
{
    public class Province
    {
        public Province()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 人口
        /// </summary>
        public int Population { get; set; }
        public List<City> Cities { get; set; }

    }
}
