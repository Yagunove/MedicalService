using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDZ_Yagunov.Andrey_MedicalService
{

    // Singleton

    // Этот класс может использоваться всеми остальными для навигации
    // Так как в нем только статические элементы, можем сделать сам класс static
    static class Pages
    {
        // Создаем каждую страницу один раз на все время запуска программы
        // Для этого используем static
        private static MainPage _mainPage = new MainPage();
        private static LoginPage _loginPage = new LoginPage();
        

        public static LoginPage LoginPage
        {
            get
            {
                return _loginPage;
            }
        }

        public static MainPage MainPage
        {
            get
            {
                return _mainPage;
            }
        }

     
    }
}
