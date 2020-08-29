using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinkaBlog.Data;
using LinkaBlog.Data.File_Manager;
using LinkaBlog.Data.Repository;
using LinkaBlog.Models;
using LinkaBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LinkaBlog.Controllers
{
    public class BlogController : Controller
    {
        private IRepository _context;
        public IFileManager _fileManager;


        public BlogController(IRepository context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;

        }
        public IActionResult Index(int pageNumber, string category,string search)

        {
            if (pageNumber < 1)
                return RedirectToAction("Index", new { pageNumber = 1,category });

            var vm = _context.GetAllPosts(pageNumber,category,search);
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(vm);
          
        }
        public IActionResult Gallery(int pageNumber, string category, string search)

        {
            if (pageNumber < 1)
                return RedirectToAction("Gallery", new { pageNumber = 1, category });

            var vm = _context.GetAllPosts(pageNumber, category, search);
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(vm);

        }
        public IActionResult Post(int id)
        {
            var posts = _context.GetPost( id);
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(posts);

        }

        [HttpGet("/Image/{image}")]
        [ResponseCache(CacheProfileName ="Monthly")]
        public IActionResult Image(string image) 
        {
            var mime = image.Substring(image.LastIndexOf('.')+1);

            return new FileStreamResult(_fileManager.ImageStream(image),$"image/{mime}");
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel commentView)
        {
            if (!ModelState.IsValid)
              
                return RedirectToAction("Post", new { id = commentView.PostId });

            var post = _context.GetPost(commentView.PostId);
    
            if (commentView.MainCommentId == 0)
            {
                post.MainComments = post.MainComments ?? new List<MainComment>();
                post.MainComments.Add(new MainComment

                
                {
                    Message = commentView.Message,
                    Name = commentView.Name,
                    Created = DateTime.Now,
                });
                _context.UpdatePost(post);
            }
            else
            {
                var comment = new SubComment
                {
                    Name = commentView.Name,
                    MainCommentId = commentView.MainCommentId,
                    Message = commentView.Message,
                    Created = DateTime.Now,
                };
                _context.AddSubComment(comment);
            }
            await _context.SaveChangesAsync();
            if (User.IsInRole("Banned"))
            {
                return RedirectToAction("Login", "Auth");
            }
            return RedirectToAction("Post", new { id = commentView.PostId });
        }
       


    }


}
