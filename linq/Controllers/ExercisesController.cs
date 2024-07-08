using LinqExercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LinqExercises.Controllers
{
    public class ExercisesController : Controller
    {
        // 1. Numbers from range
        public ActionResult NumbersFromRange()
        {
            List<int> numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };
            var result = numbers.Where(n => n > 30 && n < 100).ToList();
            return View("Result", result);
        }

        // 2. Minimum length
        public ActionResult MinimumLength()
        {
            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };
            var result = animals.Where(a => a.Length >= 5).Select(a => a.ToUpper()).ToList();
            return View("Result", result);
        }

        // 3. Select words
        public ActionResult SelectWords()
        {
            List<string> words = new List<string> { "alabam", "am", "balalam", "tara", "", "a", "axeliam", "39yo0m", "trol" };
            var result = words.Where(w => w.StartsWith("a") && w.EndsWith("m")).ToList();
            return View("Result", result);
        }

        // 4. Top 5 numbers
        public ActionResult Top5Numbers()
        {
            List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };
            var result = numbers.OrderByDescending(n => n).Take(5).ToList();
            return View("Result", result);
        }

        // 5. Square greater than 20
       // Add this namespace

public ActionResult SquareGreaterThan20()
    {
        List<int> numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };
        var result = numbers.Select(n => new NumberSquare { Number = n, Square = n * n })
                            .Where(x => x.Square > 20)
                            .ToList();
        return View("Result", result);
    }


    // 6. Most frequent character
    public ActionResult MostFrequentCharacter()
        {
            string str = "49fjs492jfJs94KfoedK0iejksKdsj3";
            var result = str.GroupBy(c => c)
                            .OrderByDescending(g => g.Count())
                            .Select(g => g.Key)
                            .FirstOrDefault();
            return View("Result", result);
        }

        // 7. Last word containing letter 'e'
        public ActionResult LastWordContainingLetter()
        {
            var words = new List<string> { "cow", "dog", "elephant", "cat", "rat", "squirrel", "snake", "stork" };
            var result = words.Where(w => w.Contains('e')).OrderBy(w => w).LastOrDefault();
            return View("Result", result);
        }
    }
}
