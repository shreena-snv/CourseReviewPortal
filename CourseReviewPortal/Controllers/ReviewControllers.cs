
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CourseReviewPortal.Models;

namespace CourseReviewPortal.Controllers
{
    public class ReviewController : Controller
    {
        private static readonly List<CourseReview> reviews =
            new List<CourseReview>();

        public ActionResult Index()
        {
            return View(reviews.OrderByDescending(r => r.ReviewId).ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new CourseReview());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseReview review)
        {
            if (ModelState.IsValid)
            {
                review.ReviewId = reviews.Count == 0
                    ? 1 : reviews.Max(r => r.ReviewId) + 1;

                review.SubmittedAt = DateTime.Now;
                reviews.Add(review);

                TempData["Success"] =
                    "Your course review has been submitted successfully!";

                return RedirectToAction("Index");
            }

            return View(review);
        }
    }
}
