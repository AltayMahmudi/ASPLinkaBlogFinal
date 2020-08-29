using LinkaBlog.Helpers;
using LinkaBlog.Models;
using LinkaBlog.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkaBlog.Data.Repository
{
	public class Repository : IRepository
	{
		private LinkaBlogDbContext _context;

		public Repository(LinkaBlogDbContext context)
		{
			_context = context;
		}
		public void AddPost(Post post)
		{
			_context.Posts.Add(post);
		}
		public List<Post> GetAllPosts()
		{
			return _context.Posts.ToList();
		}
		public IndexViewModel GetAllPosts(int pageNumber, string category, string search)
		{
			Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(category.ToLower()); };
			int pageSize = 3;
			int skipAmount = pageSize * (pageNumber - 1);

			var query = _context.Posts.AsNoTracking().AsQueryable();
			//_context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
			if (!String.IsNullOrEmpty(category))
				query = query.Where(x => InCategory(x));

			if (!String.IsNullOrEmpty(search))
				query = query.Where(x => EF.Functions.Like(x.Title, $"%{search}%") ||
										EF.Functions.Like(x.Title, $"%{search}%") ||
										EF.Functions.Like(x.Description, $"%{search}%"));
			int postsCount = query.Count();
			int pageCount = (int)Math.Ceiling((double)postsCount / pageSize);
			return new IndexViewModel
			{
				PageNumber = pageNumber,
			PageCount=pageCount,
				NextPage = postsCount > skipAmount + pageSize,
				Pages= PageHelper.PageNumbers(pageNumber,pageCount).ToList(),
				Category = category,
				Search=search,
				Posts = query
				.Skip(skipAmount)
				.Take(pageSize)
				.ToList()

			};
	}
		public List<Post> GetAllPostsSub(string subcategory)
		{
			int pageSize = 6;
			return _context.Posts.Where(post => post.SubCategory.ToLower().Equals(subcategory.ToLower())).Take(pageSize).ToList();
		}
		public Post GetPost(int id)
		{
			return _context.Posts.Include(p => p.MainComments).ThenInclude(mc => mc.SubComments).FirstOrDefault(p => p.Id == id);
		}
		public void RemovePost(int id)
		{
			_context.Posts.Remove(GetPost(id));
		}
		public void UpdatePost(Post post)
		{
			_context.Posts.Update(post);
		}
		public async Task<bool> SaveChangesAsync()
		{
			if (await _context.SaveChangesAsync() > 0) 
			{
				return true;
			}return false;
		}
		public void AddSubComment(SubComment comment)
		{
			_context.SubComments.Add(comment);
		}
		
	}
}
