using StudentLeaf.Models;
using StudentLeaf.Models.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace StudentLeaf.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Student
        public ActionResult Index()
        {
            //var students = _context.Student.Include(t => t.ActiveLessons).ToList();
            return View();//students);
        }

        public JsonResult List()
        {
            var students = _context.Student.Include(t => t.ActiveLessons).ToList();

            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            var student = _context.Student
                .Include(t => t.ActiveLessons)
                .SingleOrDefault(t => t.Id == id);

            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }

            return View(student);
        }
        public ActionResult Delete(int id)
        {
            var student = _context.Student
                .Include(n => n.ActiveLessons)
                .SingleOrDefault(n => n.Id == id);

            if (student.ActiveLessons.Count > 1)
                return HttpNotFound("This student has more than one Active Lessons");

            _context.Student.Remove(student);

            _context.SaveChanges();

            return View("Index");
        }
        public ActionResult ActiveLesson(int id, string lessonType)
        {
            var active = _context.Student
                .Include(n => n.ActiveLessons)
                .SingleOrDefault(n => n.Id == id)
                .ActiveLessons
                .Where(n => n.LessonPlan == lessonType);

            return View("Index", active);
        }

        public ActionResult Detail(int id)
        {
            var student = _context.Student.Include(t => t.ActiveLessons).Single(s => s.Id == id);






            return View("Detail", student);

        }

        public ActionResult History(int id)
        {
            var student = _context.Student.Include(t => t.History).SingleOrDefault(s => s.Id == id);

            var tDict = new Dictionary<int, string>();
            var viewModel = new HistoryInstructorViewModel();

            viewModel.Student = _context.Student.Single(s => s.Id == id);

            foreach (var l in student.History)
            {
                if (!tDict.ContainsKey(l.InstructorId))
                {
                    tDict.Add(l.InstructorId, _context.Instructor.Single(s => s.InstructorId == l.InstructorId).Name);
                }
                if (!tDict.ContainsKey(l.TInstructorId))
                {
                    tDict.Add(l.TInstructorId, _context.Instructor.Single(s => s.InstructorId == l.TInstructorId).Name);
                }
            }

            viewModel.InstructorDictionary = tDict;
            return View(viewModel);// student);
        }

        public ActionResult CreateNewStudent()
        {

            return View("CreateNewStudent");
        }
    }

}