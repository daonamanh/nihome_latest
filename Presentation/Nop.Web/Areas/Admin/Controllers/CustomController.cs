using Microsoft.AspNetCore.Mvc;
using Nop.Services.Custom;
using Nop.Services.Messages;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Models.Extensions;
using Nop.Web.Areas.Admin.Models.Custom;
using Nop.Core.Domain.Custom;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Nop.Web.Areas.Admin.Controllers
{
    [AutoValidateAntiforgeryToken]
    public partial class CustomController : BaseAdminController
    {
        private readonly ICustomService _customService;
        private readonly INotificationService _notificationService;
        private readonly string _picturePath = "images/thumbs/";  // Define the path for storing images

        public CustomController(ICustomService customService, INotificationService notificationService)
        {
            _customService = customService;
            _notificationService = notificationService;
        }

        public virtual IActionResult Index()
        {
            return RedirectToAction("Custom");
        }

        [HttpGet]
        public virtual async Task<IActionResult> Custom()
        {
            var entities = await _customService.GetAllEntitiesAsync();
            var model = entities
                 .OrderBy(entity => entity.Id).Select(entity => new CustomTableModel
                 {
                     Id = entity.Id,
                     Name = entity.Name,
                     Description = entity.Description,
                     PictureUrl = entity.PictureUrl, // Load the picture URL
                     Date = entity.Date
                 }).ToList();

            return View(model);
        }
        [HttpGet]
        public virtual async Task<IActionResult> Default()
        {
            var entities = await _customService.GetAllEntitiesAsync();
            var model = entities
                 .OrderBy(entity => entity.Id)
                 .Select(entity => new CustomTableModel
                 {
                     Id = entity.Id,
                     Name = entity.Name,
                     Description = entity.Description,
                     PictureUrl = entity.PictureUrl,
                     Date = entity.Date
                 }).ToList();

            // Ensure you're returning the correct view path
            return View("~/Views/Shared/Components/TopicBlock/Default.cshtml", model);

        }

        [HttpPost]
        public virtual async Task<IActionResult> CustomList(CustomTableModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var entity = new CustomTable
            {
                Name = model.Name,
                Description = model.Description,
                Date = model.Date,
                PictureUrl = await SavePictureAsync(model.PictureUpload)  // Save the picture
            };
            await _customService.InsertEntityAsync(entity);

            _notificationService.SuccessNotification("The custom entity has been added successfully.");
            return RedirectToAction("Custom");
        }

        public virtual IActionResult CustomCreate()
        {
            var model = new CustomTableModel();
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> CustomCreateList(CustomTableModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var entity = new CustomTable
            {
                Name = model.Name,
                Description = model.Description,
                Date = model.Date,
                PictureUrl = await SavePictureAsync(model.PictureUpload)  // Save the picture
            };
            await _customService.InsertEntityAsync(entity);

            _notificationService.SuccessNotification("The custom entity has been added successfully.");
            return RedirectToAction("Custom");
        }

        public virtual async Task<IActionResult> CustomEdit(int id)
        {
            var entity = await _customService.GetEntityByIdAsync(id);
            if (entity == null)
                return RedirectToAction("Custom");

            var model = new CustomTableModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                Date = entity.Date,
                PictureUrl = entity.PictureUrl  // Load the picture URL
            };

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> CustomEdit(CustomTableModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var entity = await _customService.GetEntityByIdAsync(model.Id);
            if (entity == null)
                return RedirectToAction("Custom");

            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.Date = model.Date;

            // Update the picture if a new one was uploaded
            if (model.PictureUpload != null)
            {
                entity.PictureUrl = await SavePictureAsync(model.PictureUpload);
            }

            await _customService.UpdateEntityAsync(entity);

            _notificationService.SuccessNotification("The custom entity has been updated successfully.");
            return RedirectToAction("Custom");
        }

        [HttpPost]
        public virtual async Task<IActionResult> CustomDelete(int id)
        {
            var entity = await _customService.GetEntityByIdAsync(id);
            if (entity == null)
                return RedirectToAction("Custom");

            await _customService.DeleteEntityAsync(entity);
            _notificationService.SuccessNotification("The custom entity has been deleted successfully.");
            return RedirectToAction("Custom");
        }

        #region Private Methods

        // Helper method to save uploaded picture
        private async Task<string> SavePictureAsync(IFormFile pictureFile)
        {
            if (pictureFile == null || pictureFile.Length == 0)
                return null;

            // Generate a unique file name for the picture
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(pictureFile.FileName)}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", _picturePath, fileName);

            // Create the directory if it doesn't exist
            var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", _picturePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Save the file to the server
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await pictureFile.CopyToAsync(stream);
            }

            // Return the absolute URL to the picture
            return $"{Request.Scheme}://{Request.Host}/{_picturePath}{fileName}";
        }
        //public IActionResult Search(string searchQuery)
        //{
        //    var items = _customService.GetAllItems(); // Replace with your data retrieval method

        //    if (!string.IsNullOrEmpty(searchQuery))
        //    {
        //        // Filter items based on search query (e.g., Name or Description contains searchQuery)
        //        items = items.Where(i => i.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
        //                                 i.Description.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
        //    }

        //    return View(items);
        //}



        #endregion
    }
}
