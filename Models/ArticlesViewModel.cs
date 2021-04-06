﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerWebAppCICDDemo.Models
{
    public class ArticlesViewModel
    {
        public List<Article> Articles { get; set; }

        public ArticlesViewModel()
        {
            Articles = new List<Article>();
        }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Content { get; set; }
    }
}
