using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using JOBTRACKMVC.Models;

namespace JOBTRACKMVC.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            IEnumerable<MvcTask> TaskList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Task").Result;         //From Global Variables Class get task result
            TaskList = response.Content.ReadAsAsync<IEnumerable<MvcTask>>().Result;
            return View(TaskList);
        }

        public ActionResult AddOrEdit(int id = 0)                       
        {
            if (id == 0)
                return View(new MvcTask());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Task/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<MvcTask>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(MvcTask task)             //Add or Edit Task
        {
            if (task.TaskId == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Task", task).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Task/" + task.TaskId, task).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)              // Delete Existing Task
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Task/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
    