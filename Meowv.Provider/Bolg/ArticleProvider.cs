﻿using Meowv.DataModel.Blog;
using Meowv.Entity.Blog;
using Meowv.Interface.Blog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meowv.Provider.Bolg
{
    public class ArticleProvider : IArticle
    {
        private readonly ArticleDataModel _data;
        public ArticleProvider(ArticleDataModel data)
        {
            _data = data;
        }

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> AddArticle(ArticleEntity entity)
        {
            return _data.AddArticle(entity);
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public Task<bool> DeleteArticle(int articleId)
        {
            return _data.DeleteArticle(articleId);
        }

        /// <summary>
        /// 更新文章
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> UpdateArticle(ArticleEntity entity)
        {
            return _data.UpdateArticle(entity);
        }

        /// <summary>
        /// 获取文章详情
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public Task<ArticleEntity> GetArticle(int articleId)
        {
            return _data.GetArticle(articleId);
        }

        /// <summary>
        /// 获取文章列表
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<ArticleEntity>> GetArticles()
        {
            return _data.GetArticles();
        }

        /// <summary>
        /// 根据分类ID获取文章列表
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Task<IEnumerable<ArticleEntity>> GetArticlesByCategoryId(int categoryId)
        {
            return _data.GetArticlesByCategoryId(categoryId);
        }

        /// <summary>
        /// 根据标签ID获取文章列表
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        public Task<IEnumerable<ArticleEntity>> GetArticlesByTagId(int tagId)
        {
            return _data.GetArticlesByTagId(tagId);
        }
    }
}