﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewTracker.BusinessLayer.Services.Repository;
using InterviewTracker.BusinessLayer.ViewModels;
using InterviewTracker.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTracker.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Creating Referancce variable of IInterviewTrackerRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IUserInterviewTrackerRepository _interviewTrackerRepository;
        public UserController(IUserInterviewTrackerRepository interviewTrackerRepository)
        {
            _interviewTrackerRepository = interviewTrackerRepository;
        }
        /// <summary>
        /// Get All User from InMemorydb and display on AllUser
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> AllUser()
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Register New User
        /// </summary>
        /// <returns></returns>
        public IActionResult RegisterUser()
        {
            return View();
        }
        /// <summary>
        /// Register new user after post, form fill
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> RegisterUser(RegisterViewModel model)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// edit Registred user 
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditUser(int UserId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Edit user after load User on edit mode
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EditUser(UserEditViewModel model)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete User from InMemory Db by passing UserId
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult DeleteUser(int UserId)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Display confirmation message to delete User
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserConfirmed(int UserId)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
