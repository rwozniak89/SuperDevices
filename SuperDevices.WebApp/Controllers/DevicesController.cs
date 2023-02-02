using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperDevices.Domain.Entities;
using SuperDevices.DataAccess.Context;
using SuperDevices.Domain.Repository;
using SuperDevices.DataAccess.Repository;
using SuperDevices.Domain.Dtos;
using AutoMapper;
using System.Security.Claims;

namespace SuperDevices.WebApp.Controllers
{
    [Authorize]
    public class DevicesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DevicesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            if (_unitOfWork.Device.IsNull())
                return Problem("Entity set 'ApplicationDbContext.Devices'  is null.");


            var list = await _unitOfWork.Device.GetAllAsync();

            var listDtos = DeviceDtoFactory.CreateCollectionDtofromModelCollection(_mapper, list);


            return View(listDtos);
        }

        // GET: Devices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
                return NotFound();
            
            if (_unitOfWork.Device.IsNull())
                return Problem("Entity set 'ApplicationDbContext.Devices'  is null.");


            var device = await _unitOfWork.Device.GetByIdAsync(id.Value);

            if (device == null)
                return NotFound();

            var deviceDto =  DeviceDtoFactory.CreateDtofromModel(_mapper, device);

            return View(deviceDto);
        }

        // GET: Devices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Devices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,SerialNumber,Id")] DeviceDto deviceDto)
        {
            if (ModelState.IsValid)
            {
                deviceDto.Id = Guid.NewGuid();

                var userId = this.User.FindFirstValue(ClaimTypes.Name);
                if (String.IsNullOrEmpty(userId))
                    return Problem("User is null.");
                var device = DeviceDtoFactory.CreateModelfromDto(_mapper, deviceDto);
                _unitOfWork.Device.Add(device, userId);

                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deviceDto);
        }

        // GET: Devices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            if (_unitOfWork.Device.IsNull())
                return Problem("Entity set 'ApplicationDbContext.Devices'  is null.");

            var device = await _unitOfWork.Device.GetByIdAsync(id.Value);

            

            if (device == null)
                return NotFound();

            var deviceDto = DeviceDtoFactory.CreateDtofromModel(_mapper, device);

            return View(deviceDto);
        }

        // POST: Devices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name,SerialNumber,Id")] DeviceDto deviceDto)
        {
            if (id != deviceDto.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.Name);
                    if (String.IsNullOrEmpty(userId))
                        return Problem("User is null.");

                    var device = await _unitOfWork.Device.GetByIdAsync(id);
                    if (device == null)
                        return NotFound();

                    DeviceDtoFactory.UpdateModelfromDto(_mapper, device, deviceDto);
                    _unitOfWork.Device.Update(device, userId);
                    await _unitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (_unitOfWork.Device.Exists(deviceDto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deviceDto);
        }

        // GET: Devices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            if (_unitOfWork.Device.IsNull())
                return Problem("Entity set 'ApplicationDbContext.Devices'  is null.");

            var device = await _unitOfWork.Device.GetByIdAsync(id.Value);

            if (device == null)
                return NotFound();
            
            var deviceDto = DeviceDtoFactory.CreateDtofromModel(_mapper, device);

            return View(deviceDto);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if(_unitOfWork.Device.IsNull())
                return Problem("Entity set 'ApplicationDbContext.Devices'  is null.");

            var device = await _unitOfWork.Device.GetByIdAsync(id);

            if (device != null)
            {
                _unitOfWork.Device.Remove(device);
            }

            await _unitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
