using ASP.Net_MVC_Day4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ASP.Net_MVC_Day4.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var books = _context.Books.Include(m => m.Category).ToList();
            return View(books);
        }

        public ActionResult Create()
        {
            var viewModel = new BookFormViewModel
            {
                Categories = _context.Categories.Where(m => m.IsActive).ToList()
            };
            return View("BookForm", viewModel);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var book = _context.Books.Find(id);

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                CategoryId = book.CategoryId,
                Categories = _context.Categories.Where(m => m.IsActive).ToList()
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(BookFormViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    model.Categories = _context.Categories.Where(m => m.IsActive).ToList();
                    return View("BookForm", model);
                }

                if (model.Id == 0)
                {
                    var book = new Book
                    {
                        Title = model.Title,
                        Author = model.Author,
                        CategoryId = model.CategoryId
                    };
                    _context.Books.Add(book);
                }
                else
                {
                    var book = _context.Books.Find(model.Id);

                    if (book == null)
                        return HttpNotFound();

                    book.Title = model.Title;
                    book.Author = model.Author;
                    book.CategoryId = model.CategoryId;
                }

                _context.SaveChanges();

                //TempData["SuccessMessage"] = "Book saved successfully.";
                Session["SuccessMessage"] = "Book saved successfully.";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while saving the book: " + ex.Message;
                return View("Error");
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            var book = _context.Books.Find(id);

            if (book == null)
                return HttpNotFound();

            _context.Books.Remove(book);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}