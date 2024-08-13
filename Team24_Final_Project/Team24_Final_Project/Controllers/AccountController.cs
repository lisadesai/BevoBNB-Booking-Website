using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;
using Team24_Final_Project.Utilities;

namespace Team24_Final_Project.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private SignInManager<AppUser> _signInManager;
        private UserManager<AppUser> _userManager;
        private PasswordValidator<AppUser> _passwordValidator;
        private AppDbContext _context;

        public AccountController(AppDbContext appDbContext, UserManager<AppUser> userManager, SignInManager<AppUser> signIn)
        {
            _context = appDbContext;
            _userManager = userManager;
            _signInManager = signIn;
            //user manager only has one password validator
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel rvm)
        {
            //if registration data is valid, create a new user on the database
            if (ModelState.IsValid == false)
            {
                //this is the sad path - something went wrong, 
                //return the user to the register page to try again
                return View(rvm);
            }

            if (rvm.Adult == false)
            {
                return View("Error", new String[] { "You must be at least 18 years or older to have an account with BevoBnB. Please grow up and try again later." });
            }

            // verify that no two customers have the same email
            var count = _context.Users.FirstOrDefault(u => u.Email == rvm.Email);

            if (count != null)
            {
                return View("Error", new String[] { "This email is already in use." });
            }

            //this code maps the RegisterViewModel to the AppUser domain model
            AppUser newUser = new AppUser
            {
                UserName = rvm.Email,
                Email = rvm.Email,
                PhoneNumber = rvm.PhoneNumber,

                //FirstName is included as an example
                FirstName = rvm.FirstName,
                LastName = rvm.LastName,
                MiddleInitial = rvm.MiddleInitial,
                Address = rvm.Address,
                Zip = rvm.Zip,
                Birthday = rvm.Birthday,
                Adult = rvm.Adult,
                IsActive = rvm.IsActive
            };

            //create AddUserModel
            AddUserModel aum = new AddUserModel()
            {
                User = newUser,
                Password = rvm.Password,
            };
            if (rvm.roleChoice == RoleChoice.Customer)
            {
                aum.RoleName = "Customer";
            }
            if (rvm.roleChoice == RoleChoice.Host)
            {
                aum.RoleName = "Host";
            }



            //SEND EMAIL
            string subject = " Welcome to BevoBnB!";

            string body = "Explore our hundreds of properties to find your next rental today.";

            SendMail.EmailMessaging.SendEmail(rvm.Email, subject, body);



            //This code uses the AddUser utility to create a new user with the specified password
            IdentityResult result = await Utilities.AddUser.AddUserWithRoleAsync(aum, _userManager, _context);

            if (result.Succeeded) //everything is okay
            { 
                //NOTE: This code logs the user into the account that they just created
                //You may or may not want to log a user in directly after they register - check
                //the business rules!
                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);

                //Send the user to the home page
                return RedirectToAction("Index", "Home");
            }
            else  //the add user operation didn't work, and we need to show an error message
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send user back to page with errors
                return View(rvm);
            }
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            if (User.Identity.IsAuthenticated) //user has been redirected here from a page they're not authorized to see
            {
                return View("Error", new string[] { "Access Denied" });
            }

           

            _signInManager.SignOutAsync(); //this removes any old cookies hanging around
            ViewBag.ReturnUrl = returnUrl; //pass along the page the user should go back to
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel lvm, string returnUrl)
        {
            AppUser user = _context.Users.FirstOrDefault(u => u.Email == lvm.Email);

            if (user.IsActive == false)
            {
                return View("Error", new String[] { "This user isn't active" });
            }

            //if user forgot to include user name or password,
            //send them back to the login page to try again
            if (ModelState.IsValid == false)
            {
                return View(lvm);
            }

            //attempt to sign the user in using the SignInManager
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);

            //if the login worked, take the user to either the url
            //they requested OR the homepage if there isn't a specific url
            if (result.Succeeded)
            {
                //return ?? "/" means if returnUrl is null, substitute "/" (home)
                return Redirect(returnUrl ?? "/");
            }
            else //log in was not successful
            {
                //add an error to the model to show invalid attempt
                ModelState.AddModelError("", "Invalid login attempt.");
                //send user back to login page to try again
                return View(lvm);
            }
        }

        //GET: Account/Index
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();

            //get user info
            String id = User.Identity.Name;
            AppUser user = _context.Users.FirstOrDefault(u => u.UserName == id);

            //populate the view model
            //(i.e. map the domain model to the view model)
            ivm.Email = user.Email;
            ivm.HasPassword = true;
            ivm.UserID = user.Id;
            ivm.UserName = user.UserName;

            //send data to the view
            return View(ivm);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ChangeAdminPassword(String userID)
        {
            ChangeAdminPasswordViewModel capvm = new ChangeAdminPasswordViewModel
            {
                UserToChangeID = userID
            };

            return View(capvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> ChangeAdminPassword(ChangeAdminPasswordViewModel capvm)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(capvm);
            }
            AppUser dbUser = _context.Users.Find(capvm.UserToChangeID);
            var token = await _userManager.GeneratePasswordResetTokenAsync(dbUser);
            await _userManager.ResetPasswordAsync(dbUser, token, capvm.NewPassword);

            return RedirectToAction("Index", "RoleAdmin");
        }


        //Logic for change password
        // GET: /Account/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        

        // POST: /Account/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel cpvm)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser userLoggedIn = await _userManager.FindByNameAsync(User.Identity.Name);

            //Attempt to change the password using the UserManager
            var result = await _userManager.ChangePasswordAsync(userLoggedIn, cpvm.OldPassword, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {
                //sign in the user with the new password
                await _signInManager.SignInAsync(userLoggedIn, isPersistent: false);

                //send the user back to the home page
                return RedirectToAction("Index", "Home");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }

        //GET:/Account/AccessDenied
        public IActionResult AccessDenied(String ReturnURL)
        {
            return View("Error", new string[] { "Access is denied" });
        }

        // POST: /Account/LogOff
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LogOff()
        {
            //sign the user out of the application
            _signInManager.SignOutAsync();

            //send the user back to the home page
            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AllUsers()
        {
            ViewBag.AllUsers = GetAllUsers();
            return View();
        }
        
        public IActionResult Edit()
        {
            AppUser user = _context.Users.FirstOrDefault(u => u.Email == User.Identity.Name);

            return View(user);
        }

        [HttpPost]
        public IActionResult EditUsers(string SelectedUserID)
        {
            AppUser user = _context.Users.Find(SelectedUserID);

            return View("Edit", user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AppUser user)
        {
            AppUser dbUser = _context.Users.FirstOrDefault(u => u.Email == user.UserName);

            if (user.Adult == false)
            {
                return View("Error", new String[] { "You must be over 18 to have an account." });
            }

            // update the database values
            dbUser.Address = user.Address;
            dbUser.PhoneNumber = user.PhoneNumber;
            dbUser.Birthday = user.Birthday;
            dbUser.IsActive = user.IsActive;

            _context.Update(dbUser);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        private SelectList GetAllUsers()
        {
            List<AppUser> allUsers = _context.Users.ToList();

            SelectList slAllUsers = new SelectList(allUsers, nameof(AppUser.Id), nameof(AppUser.Email));

            return slAllUsers;
        }
    }
}