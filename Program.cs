using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PayrollSystem.controller;

namespace PayrollSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UserControllerInterface userController = new UserController();
            //userController.index();
            FormControllerInterface formController = new FormController();
            formController.index();
        }
    }
}
