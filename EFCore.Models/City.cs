using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Domain.Models
{
    public class City
    {

        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// 区号
        /// </summary>
        public int AreaCode { get; set; }
        /// <summary>
        /// 省份ID
        /// </summary>
        public int ProvinceId { get; set; }
        public Province Procince { get; set; }

    }
}
