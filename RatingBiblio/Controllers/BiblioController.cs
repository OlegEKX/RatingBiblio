using Microsoft.AspNetCore.Mvc;
using RatingBiblio.Models;

namespace RatingBiblio.Controllers
{
    public class BiblioController : Controller
    {
        private readonly BookRepository _bookRepository;

        public BiblioController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.AddBook(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public IActionResult Edit(int id) // отображение предствления редактирования книги по её идентификатору
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book) // вызывается при отправке формы для редактирования книги
        {
            if (ModelState.IsValid) // прошла ли книга валидацию
            {
                _bookRepository.UpdateBook(book); //обновляет информацию о книге в репозитории
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
    }
}
