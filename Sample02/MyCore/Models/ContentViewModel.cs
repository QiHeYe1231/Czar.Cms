using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MyCore.Models.ContentBase;

namespace MyCore.Models
{
    public class ContentViewModel
    {
        /// <summary>
        /// 内容列表
        /// </summary>
        public List<Content> Contents { get; set; }
    }
}
