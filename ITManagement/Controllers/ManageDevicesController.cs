﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITManagement.Models;

namespace ITManagement.Controllers
{
    public class ManageDevicesController : Controller
    {
        private readonly ITManagementContext _context;

        public ManageDevicesController(ITManagementContext context)
        {
            _context = context;
        }

        // GET: ManageDevices

        public IActionResult Index()
        {
            List<Categories> list = _context.Categories.ToList();
            var put = list.Select(val => new SelectListItem
            {
                Text = val.CategoryName,
                Value = val.CategoryId.ToString(),
            }).ToList();
            ViewBag.CategoryId = put;
            ViewBag.UserId = new SelectList(_context.Users, "UserId", "UserId");
            var obj1 = _context.Devices.Include(d => d.User).Include(d => d.Category).ToList();
            ViewBag.Device = obj1;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Categories> list = _context.Categories.ToList();
            var put = list.Select(val => new SelectListItem
            {
                Text = val.CategoryName,
                Value = val.CategoryId.ToString(),
            }).ToList();
            ViewBag.CategoryId = put;
            ViewBag.UserId = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }


        [HttpPost]

        public IActionResult Create([Bind("DeviceName,CategoryId,Description,Status,UserId,AllotedDate,CreatedBy,CreatedAt,UpdatedAt,UpdatedBy")] Devices devices)
        {
            if (ModelState.IsValid)
            {
                devices.CreatedBy = "admin";
                devices.UpdatedBy = "admin";
                devices.UpdatedAt = DateTime.Now;

                devices.CreatedAt = DateTime.Now;
                if (devices.Status)
                {
                    devices.AllotedDate = DateTime.Now;

                }
                else
                {
                    devices.AllotedDate = null;
                }
                _context.Add(devices);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", devices.CategoryId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", devices.UserId);
            return View(devices);
        }


        [HttpPost]
        public IActionResult DeleteDevice(int deleteDeviceId)
        {
            var Use = _context.Devices.FirstOrDefault(u => u.DeviceId == deleteDeviceId);

            _context.Devices.Remove(Use);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Edit(Devices updatedDevice)
        {
            if (ModelState.IsValid)
            {
                // Find the existing Device entity by its DeviceID.
                var existingDevice = _context.Devices.FirstOrDefault(D => D.DeviceId == updatedDevice.DeviceId);

                if (existingDevice == null)
                {
                    return NotFound("Device not found");
                }

                string defaultUpdatedBy = "admin";
                string defaultCreatedBy = "admin";
                DateTime? defaultUpdatedAt = null;
                DateTime currentDateTime = DateTime.Now;


                // Update the properties of the existing Device entity with the values from the updatedDevice.
                existingDevice.DeviceName = updatedDevice.DeviceName;
                existingDevice.CategoryId = updatedDevice.CategoryId;
                existingDevice.Description = updatedDevice.Description;
                existingDevice.Status = updatedDevice.Status;
                if (existingDevice.Status == false)
                {
                    existingDevice.AllotedDate = null;
                    existingDevice.UserId = null;
                }
                else
                {
                    existingDevice.UserId = updatedDevice.UserId;
                    existingDevice.AllotedDate = currentDateTime;


                }
                existingDevice.CreatedBy = defaultCreatedBy;
                existingDevice.UpdatedBy = defaultUpdatedBy;
                existingDevice.UpdatedAt = defaultUpdatedAt;
                existingDevice.CreatedAt = currentDateTime;

                // Save the changes to the database.
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            // If the ModelState is not valid, return to handle validation errors.
            return BadRequest(ModelState);
        }





        //// GET: ManageDevices/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var devices = await _context.Devices.FindAsync(id);
        //    if (devices == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", devices.CategoryId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", devices.UserId);
        //    return View(devices);
        //}

        //// POST: ManageDevices/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,DeviceId,DeviceName,CategoryId,Description,Status,UserId,AllotedDate,CreatedBy,CreatedAt,UpdatedAt,UpdatedBy")] Devices devices)
        //{
        //    if (id != devices.DeviceId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(devices);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!DevicesExists(devices.DeviceId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", devices.CategoryId);
        //    ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", devices.UserId);
        //    return View(devices);
        //}

        //// GET: ManageDevices/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var devices = await _context.Devices
        //        .Include(d => d.Category)
        //        .Include(d => d.User)
        //        .FirstOrDefaultAsync(m => m.DeviceId == id);
        //    if (devices == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(devices);
        //}

        //// POST: ManageDevices/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var devices = await _context.Devices.FindAsync(id);
        //    _context.Devices.Remove(devices);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool DevicesExists(int id)
        //{
        //    return _context.Devices.Any(e => e.DeviceId == id);
        //}
    }
}