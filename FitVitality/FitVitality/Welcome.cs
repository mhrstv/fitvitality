using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;

namespace FitVitality
{
    public partial class Welcome : KryptonForm
    {
        List<Panel> listPanels = new List<Panel>();
        int page = 0;

        private bool mouseDown;
        private Point lastLocation;


        private bool female_Clicked = false; // Променлива за проверка дали е натиснат бутона за женски пол
        private bool male_Clicked = false; // Променлива за проверка дали е натиснат бутона за мъжки пол
        private bool cut_Clicked = false; // Променлива за проверка дали е натиснат бутона за цел, в случая Cut
        private bool maintain_Clicked = false; // Променлива за проверка дали е натиснат бутона за цел, в случая Maintain
        private bool bulk_Clicked = false; // Променлива за проверка дали е натиснат бутона за цел, в случая Bulk

        private string dbName; // Променлива за името
        private string dbAge; // Променлива за възрастта
        private string dbGender; // Променлива за пола
        private string dbWeight; // Променлива за теглото
        private string dbHeight; // Променлива за височината
        private string dbGoal; // Променлива за целта
        public string _userID; // Променлива за UserID

        const string connectionString = @"Server=tcp: mssql-163547-0.cloudclusters.net, 10009;Initial Catalog=FitVitality;User ID=Member;Password=Userpass123!;Connection Timeout=30;TrustServerCertificate=True";
        public Welcome(string userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        private void Welcome_Load(object sender, EventArgs e) // Анимация при зареждане на формата
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                errorLabel.Text = "Error";
                welcomeErrorLabel.Text = "You have input incorrect\r\ndata!";
                buttonDone.Text = "Done";
                ageQuestion.Text = "How old are you?";
                info1_ageGender.Text = "We do NOT share any of your private data and\r\n";
                genderQuestion.Text = "What is your gender?";
                goalLabel1.Text = "Lastly, we need to know what your goal is.\r\n";
                heightQuestion.Text = "How tall are you?";
                info1_weightHeight.Text = "We do NOT share any of your private data and\r\n";
                info2_ageGender.Text = "use it only for in-app use such as formulas.\r\n";
                info2_weightHeight.Text = "You can update these later!\r\n";
                info3_weightHeight.Text = "use it only for in-app use such as formulas.\r\n";
                labelWelcome.Text = "Welcome!";
                name_UsageLabel.Text = "Note that we will only be using your name to address you within the app.\r\n";
                nameLabel1.Text = "We would like to know a bit more about you before we continue.\r\n";
                nameLabelFirst.Text = "Now to get to know each other we would like to ask you a few questions.\r\n";
                nameQuestion.Text = "What is your name?";
                timerLabel.Text = "aaaaaaa";
                timerLabel2.Text = "";
                timerLabel3.Text = "";
                weightHeightQuestion1.Text = "Please provide us with your weight and height.\r\n";
                weightHeightQuestion2.Text = "We will be using these measurements for future calculations.\r\n";
                weightQuestion.Text = "How much do you weigh?\r\n";
                textBox_Age.CueHint.CueHintText = "ex. 25";
                textBox_Height.CueHint.CueHintText = "ex.183";
                textBox_Name.CueHint.CueHintText = "ex. \"John\"";
                textBox_Weight.CueHint.CueHintText = "ex. 82";
                maleButton.Image = Properties.Resources.male1;
                femaleButton.Image = Properties.Resources.female1;
                buttonBulk.Image = Properties.Resources.gainNormal;
                buttonCut.Image = Properties.Resources.loseNormal;
                buttonMaintain.Image = Properties.Resources.maintainNormal;
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                errorLabel.Text = "Грешка";
                welcomeErrorLabel.Text = "Въвели сте грешни\r\nданни!";
                buttonDone.Text = "Готово";
                ageQuestion.Text = "На каква възраст сте?";
                info1_ageGender.Text = "Не използваме вашите данни за нищо друго\r\n";
                genderQuestion.Text = "От какъв пол сте?";
                goalLabel1.Text = "Последно, ще ни трябва вашата цел.\r\n";
                heightQuestion.Text = "Колко сте високи?";
                info1_weightHeight.Text = "Не използваме вашите данни за нищо друго\r\n";
                info2_ageGender.Text = "освен за пресмятания в приложението.\r\n";
                info2_weightHeight.Text = "Можете да промените по-късно!\r\n";
                info3_weightHeight.Text = "освен за пресмятания в приложението.\r\n";
                labelWelcome.Text = "Добре дошли!";
                name_UsageLabel.Text = "Ще ни трябва името ви само за да се обръщаме към вас.";
                nameLabel1.Text = "Ще трябва да знаем повече за вас преди да продължите.\r\n";
                nameLabelFirst.Text = "Сега за да се запознаем по-добре ще ви попитаме няколко въпроса.\r\n";
                nameQuestion.Text = "Как се казвате?";
                timerLabel.Text = "aaaaaaa";
                timerLabel2.Text = "";
                timerLabel3.Text = "";
                weightHeightQuestion1.Text = "Моля споделете вашето тегло и ръст.\r\n";
                weightHeightQuestion2.Text = "Ще ползваме тези измервания за бъдещи калкулации.\r\n";
                weightQuestion.Text = "Колко тежите?\r\n";
                textBox_Age.CueHint.CueHintText = "пр. 25";
                textBox_Height.CueHint.CueHintText = "пр.183";
                textBox_Name.CueHint.CueHintText = "пр. \"Иван\"";
                textBox_Weight.CueHint.CueHintText = "пр. 82";
                maleButton.Image = Properties.Resources.malebg;
                femaleButton.Image = Properties.Resources.femalebg;
                buttonBulk.Image = Properties.Resources.gainNormalbg;
                buttonCut.Image = Properties.Resources.loseNormalbg;
                buttonMaintain.Image = Properties.Resources.maintainNormalbg;
            }
            buttonPrevious.Visible = false; // Скриване на бутона за предишна страница
            buttonNext.Visible = false; // Скриване на бутона за следваща страница
            namePanel.Visible = false; // Скриване на панела за въвеждане на име
            ageGender_Panel.Visible = false; // Скриване на панела за въвеждане на възраст и пол
            weightHeight_Panel.Visible = false; // Скриване на панела за въвеждане на тегло и височина
            goalPanel.Visible = false; // Скриване на панела за избор на цел
            //
            // Скрива панелите за да се изпълни анимацията
            //
            listPanels.Add(namePanel); // Добавяне на панела за въвеждане на име в листа с панели
            listPanels.Add(ageGender_Panel); // Добавяне на панела за въвеждане на възраст и пол в листа с панели
            listPanels.Add(weightHeight_Panel); // Добавяне на панела за въвеждане на тегло и височина в листа с панели
            listPanels.Add(goalPanel); // Добавяне на панела за избор на цел в листа с панели
            listPanels[page].BringToFront(); // Показване на първия панел от листа с панели

            welcomeLabelTimer.Enabled = true; // Включване на таймера за анимация на надписа за добре дошли"
        }

        private void buttonMin_Click(object sender, EventArgs e) // Метод при натискане на бутона за минимизиране на формата
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized; // Минимизиране на формата
        }

        private void buttonClose_Click(object sender, EventArgs e) // Метод при натискане на бутона за затваряне на формата
        {
            Application.Exit(); // Затваряне на програмата и всички нейни процеси
        }

        private void buttonMin_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за минимизиране на формата, цвета на бутона се променя
        {
            buttonMin.BackColor = Color.Silver; // Промяна на цвета на бутона
        }

        private void buttonMin_MouseLeave(object sender, EventArgs e) // При премахване на мишката от бутона за минимизиране на формата, цвета на бутона се връща към нормалния
        {
            buttonMin.BackColor = Color.FromArgb(36, 41, 46); // Промяна на цвета на бутона
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за затваряне на формата, цвета на бутона се променя
        {
            buttonClose.BackColor = Color.IndianRed; // Промяна на цвета на бутона
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e) // При премахване на мишката от бутона за затваряне на формата, цвета на бутона се връща към нормалния
        {
            buttonClose.BackColor = Color.FromArgb(36, 41, 46); // Промяна на цвета на бутона
        }

        private void topbar_MouseDown(object sender, MouseEventArgs e) // Метод при натискане на бутона на мишката върху горната лента на формата (местене из екрана)
        {
            mouseDown = true; // Променливата mouseDown се променя на true
            lastLocation = e.Location; // Променливата lastLocation се променя на последната позиция на мишката
        }

        private void topbar_MouseMove(object sender, MouseEventArgs e) // Метод при движение на мишката върху горната лента на формата (местене из екрана)
        {
            if (mouseDown) // Проверка дали е натиснат бутон на мишката
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); // Променяне на позицията на формата

                this.Update(); // Обновяване на формата
            }
        }

        private void topbar_MouseUp(object sender, MouseEventArgs e) // Метод при отпускане на бутона на мишката върху горната лента на формата (местене из екрана)
        {
            mouseDown = false; // Променливата mouseDown се променя на false
        }
        private void Welcome_Shown(object sender, EventArgs e) // Метод за анимация при първо показване на формата
        {
            this.Opacity = 0; // Прозрачността на формата се променя на 0
            while (this.Opacity != 1) // Цикъл докато прозрачността на формата не стане 1
            {
                this.Opacity += 0.00004; // Увеличаване на прозрачността на формата с 0.00004
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e) // Метод при натискане на бутона за предишна страница
        {
            dbName = textBox_Name.Text.ToString(); // Присвояване на въведеното име в променливата dbName
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                helloLabel.Text = "Hello, " + dbName + "! Thank you for choosing FitVitality!"; // Промяна на текста в надписа
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                helloLabel.Text = "Здравейте, " + dbName + "! Благодарим, че избрахте FitVitality!"; // Промяна на текста в надписа
            }
            if (page > 0) // Проверка дали сегашната страница е по-голяма от 0
            {
                page--; // Намаляне на сегашната страница с 1
                listPanels[page].BringToFront(); // Показване на предишната страница
                buttonNext.Visible = true; // Показване на бутона за следваща страница
            }
            else if (page < listPanels.Count - 1) // Проверка дали сегашната страница е по-малка от броя на страниците
            {
                buttonPrevious.Visible = true; // Показване на бутона за предишна страница
            }
            if (page == 0) // Проверка дали сегашната страница е с индекс 0
            {
                buttonPrevious.Visible = false; // Скриване на бутона за предишна страница
                currentPage.Image = Properties.Resources.firstPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
            if (page == 1) // Проверка дали сегашната страница е с индекс 1
            {
                currentPage.Image = Properties.Resources.secondPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
            if (page == 2) // Проверка дали сегашната страница е с индекс 2
            {
                currentPage.Image = Properties.Resources.thirdPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
            if (page == 3)// Проверка дали сегашната страница е с индекс 3
            {
                currentPage.Image = Properties.Resources.fourthPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
        }

        private void buttonNext_Click(object sender, EventArgs e) // Метод при натискане на бутона за следваща страница
        {
            dbName = textBox_Name.Text.ToString(); // Присвояване на въведеното име в променливата dbName
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                helloLabel.Text = "Hello, " + dbName + "! Thank you for choosing FitVitality!"; // Промяна на текста в надписа
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                helloLabel.Text = "Здравейте, " + dbName + "! Благодарим, че избрахте FitVitality!"; // Промяна на текста в надписа
            }
            if (page < listPanels.Count - 1) // Проверка дали сегашната страница е по-малка от броя на страниците
            {
                page++; // Увеличаване на сегашната страница с 1
                listPanels[page].BringToFront(); // Показване на следващата страница
                buttonPrevious.Visible = true; // Показване на бутона за предишна страница
            }
            else if (page > 0) // Проверява дали сегашната страница е по-голяма от 0
            {
                buttonNext.Visible = true; // Показване на бутона за следваща страница
            }
            if (page == listPanels.Count - 1) // Проверка дали сегашната страница е с индекс равен на броя на страниците
            {
                buttonNext.Visible = false; // Скриване на бутона за следваща страница
            }
            if (page == 1 && timerLabel3.Visible == false) // Проверка дали сегашната страница е с индекс 1 и дали таймера за анимация на надписа е изключен
            {
                timerAge1.Enabled = true; // Включване на таймера за анимация на страницата за въвеждане на възраст и пол
            }
            if (page == 2 && timerLabel2.Visible == false) // Проверка дали сегашната страница е с индекс 2 и дали таймера за анимация на надписа е изключен
            {
                timerWeight1.Enabled = true; // Включване на таймера за анимация на страницата за въвеждане на тегло и височина
            }
            if (page == 3 && timerLabel.Visible == false) // Проверка дали сегашната страница е с индекс 3 и дали таймера за анимация на надписа е изключен
            {
                timerGoal1.Enabled = true; // Включване на таймера за анимация на страницата за избор на цел
            }
            if (page == 0) // Проверка дали сегашната страница е с индекс 0
            {
                currentPage.Image = Properties.Resources.firstPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
            if (page == 1) // Проверка дали сегашната страница е с индекс 1
            {
                currentPage.Image = Properties.Resources.secondPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
            if (page == 2) // Проверка дали сегашната страница е с индекс 2
            {
                currentPage.Image = Properties.Resources.thirdPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
            if (page == 3) // Проверка дали сегашната страница е с индекс 3
            {
                currentPage.Image = Properties.Resources.fourthPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // Таймер за анимация на надписа за добре дошли
        {
            if (panelWelcome.Width <= 609) // Проверка дали ширината на панела е по-малка от 609
            {
                panelWelcome.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (panelWelcome.Width >= 609) // Проверка дали ширината на панела е по-голяма от 609
            {
                welcomeLabelTimer.Enabled = false; // Изключване на таймера
                Thread.Sleep(500); // Паузира програмата за 0.5 секунди
                timerName1.Enabled = true; // Включване на следващия таймер
                panelWelcome.Visible = false; // Скриване на панела за добре дошли
                namePanel.Visible = true; // Показване на панела за въвеждане на име
                ageGender_Panel.Visible = true; // Показване на панела за въвеждане на възраст и пол
                weightHeight_Panel.Visible = true; // Показване на панела за въвеждане на тегло и височина
                goalPanel.Visible = true; // Показване на панела за избор на цел
                currentPage.Image = Properties.Resources.firstPage; // Промяна на изображението на сегашната страница (долна снимка, представляваща номера на страницата, на която сте)
            }
        }
        private bool validName(string name) // Метод за проверка на въведеното име
        {
            foreach (char c in name) // Преминава през всеки символ от въведеното име
            {
                if (!char.IsLetter(c)) // Проверка дали въведеното име съдържа само букви
                {
                    return false; // Връща false ако името съдържа символи различни от букви
                }
            }
            if (name.Length < 1 || name.Length > 20)
            {
                return false;
            }
            return true;
        }
        private bool validAge(string age) // Метод за проверка на въведената възраст
        {
            if (age == "") return false;
            foreach (char c in age) // Преминава през всеки символ от въведената възраст
            {
                if (!char.IsNumber(c)) // Проверка дали въведената възраст съдържа само цифри
                {
                    return false; // Връща false ако въведената възраст съдържа символи различни от цифри
                }
            }
            if (int.Parse(age) < 13 || int.Parse(age) > 120) // Проверка дали въведената възраст е между 13 и 120 години
            {
                return false; // Връща false ако въведената възраст е по-малка от 13 или по-голяма от 120
            }
            return true; // Връща true ако успешно премине през проверките в метода
        }
        private bool validWeight(string weight) // Метод за проверка на въведеното тегло
        {
            if (weight == "") return false;
            foreach (char c in weight) // Преминава през всеки символ от въведеното тегло
            {
                if (!char.IsNumber(c)) // Проверка дали въведеното тегло съдържа само цифри
                {
                    return false; // Връща false ако въведеното тегло съдържа символи различни от цифри
                }
            }
            if (double.Parse(weight) < 30.00 && double.Parse(weight) > 400.00) // Проверка дали въведеното тегло е между 30 и 400 килограма
            {
                return false; // Връща false ако въведеното тегло е по-малко от 30 или по-голямо от 400
            }
            return true; // Връща true ако успешно премине през проверките в метода
        }
        private bool validHeight(string height) // Метод за проверка на въведената височина
        {
            if (height == "") return false;
            foreach (char c in height) // Преминава през всеки символ от въведената височина
            {
                if (!char.IsNumber(c)) // Проверка дали въведената височина съдържа само цифри
                {
                    return false; // Връща false ако въведената височина съдържа символи различни от цифри
                }
            }
            if (double.Parse(height) < 50 && double.Parse(height) > 300) // Проверка дали въведената височина е между 50 и 300 сантиметра
            {
                return false; // Връща false ако въведената височина е по-малка от 50 или по-голяма от 300
            }
            return true; // Връща true ако успешно премине през проверките в метода
        }

        private void done_Click(object sender, EventArgs e) // Метод за приключване на регистрацията
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            dbName = textBox_Name.Text.ToString(); // Присвояване на въведеното име в променливата dbName
            dbAge = textBox_Age.Text; // Присвояване на въведената възраст в променливата dbAge
            if (male_Clicked) // Проверка дали е натиснат бутона за мъжки пол
            {
                dbGender = "Male"; // Присвоява съответно избраният пол в променливата dbGender
            }
            else
            {
                dbGender = "Female"; // Присвоява съответно избраният пол в променливата dbGender
            }
            dbWeight = textBox_Weight.Text; // Присвояване на въведеното тегло в променливата dbWeight
            dbHeight = textBox_Height.Text; // Присвояване на въведената височина в променливата dbHeight
            if (bulk_Clicked) // Проверка дали е натиснат бутона за цел, в случая Bulk
            {
                dbGoal = "Bulk"; // Присвоява съответно избраната цел в променливата dbGoal
            }
            else if (cut_Clicked) // Проверка дали е натиснат бутона за цел, в случая Cut
            {
                dbGoal = "Cut"; // Присвоява съответно избраната цел в променливата dbGoal
            }
            else
            {
                dbGoal = "Maintain"; // Присвоява съответно избраната цел в променливата dbGoal
            }
            if (validName(dbName) && validAge(dbAge) && validWeight(dbWeight) && validHeight(dbHeight) && dbGender != "" && dbGoal != "") // Валидация за въведи данни чрез методи
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) // Създаване на връзка с базата данни
                {
                    connection.Open(); // Отваряне на връзката с базата данни
                    string query = "UPDATE UserSettings " +
                               "SET Name = @Name, Age = @Age, Gender = @Gender, Weight = @Weight, Height = @Height, Goal = @Goal " +
                               "WHERE UserID = @UserID"; // Заявка за обновяване на данните в таблицата UserSettings
                    using (SqlCommand command = new SqlCommand(query, connection)) // Създаване на команда за изпълнение на заявката
                    {
                        int age = int.Parse(dbAge); // Преобразуване на въведената възраст от стринг в инт
                        double weight = double.Parse(dbWeight); // Преобразуване на въведеното тегло от стринг в дабъл(реално число)
                        weight = Math.Round(weight, 1); // Закръгляне на въведеното тегло до 1 десетична запетая
                        int height = int.Parse(dbHeight); // Преобразуване на въведената височина от стринг в инт
                        command.Parameters.AddWithValue("@UserID", _userID); // Добавяне на параметър за UserID
                        command.Parameters.AddWithValue("@Name", dbName); // Добавяне на параметър за Name
                        command.Parameters.AddWithValue("@Age", age); // Добавяне на параметър за Age
                        command.Parameters.AddWithValue("@Gender", dbGender); // Добавяне на параметър за Gender
                        command.Parameters.AddWithValue("@Weight", weight); // Добавяне на параметър за Weight
                        command.Parameters.AddWithValue("@Height", height); // Добавяне на параметър за Height
                        command.Parameters.AddWithValue("@Goal", dbGoal); // Добавяне на параметър за Goal
                        command.ExecuteNonQuery(); // Изпълнение на командата
                        //
                        // При използването на по-горе въведените параметри се изгражда защита срещу SQL Injection!
                        //
                        Form1 main = new Form1(_userID); // Създаване на обект от класа Form1 (главната форма [Main])
                        for (double i = this.Opacity; i >= 0; i = i - 0.00004) // Анимация за затваряне на активната форма
                        {
                            this.Opacity = i;
                        }
                        Thread.Sleep(500); // Паузира програмата за 0.5 секунди, създава се ефект на затъмняване и натоварване
                        this.Hide(); // Скриване на активната форма
                        main.Show(); // Показване на главната форма
                    }
                }
            }
            else
            {
                errorPanel.Visible = true;
            }
        }

        private void timername1_Tick(object sender, EventArgs e) // Таймер за анимация на панела за въвеждане на име
        {
            if (namePanel1.Width <= 482) // Проверка дали ширината на панела е по-малка от 482
            {
                namePanel1.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (namePanel1.Width >= 482) // Проверка дали ширината на панела е по-голяма от 482
            {
                timerName1.Enabled = false; // Изключване на таймера
                timerName2.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerName_Tick(object sender, EventArgs e) // Таймер за анимация на панела за въвеждане на име
        {
            if (namePanel2.Width <= 142) // Проверка дали ширината на панела е по-малка от 142
            {
                namePanel2.Width += 2; // Увеличаване на ширината на панела с 2
            }
            if (namePanel2.Width >= 142)  // Проверка дали ширината на панела е по-голяма от 142
            {
                timerName2.Enabled = false; // Изключване на таймера
                textBox_Name.Visible = true; // Показване на текстовото поле за въвеждане на име
                timerName3.Enabled = true; // Включване на следващия таймер
            }
        }

        private void buttonPrevious_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за предишна страница се анимира чрез снимка (Правена чрез Photoshop)
        {
            buttonPrevious.Image = Properties.Resources.previoustracked; // Промяна на изображението на бутона
        }

        private void buttonPrevious_MouseLeave(object sender, EventArgs e) // При премахване на мишката от бутона за предишна страница се връща нормалното състояние на снимката
        {
            buttonPrevious.Image = Properties.Resources.triangleprevious; // Промяна на изображението на бутона
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за следваща страница се анимира чрез снимка (Правена чрез Photoshop)
        {
            buttonNext.Image = Properties.Resources.nexttracked; // Промяна на изображението на бутона
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e) // При премахване на мишката от бутона за следваща страница се връща нормалното състояние на снимката
        {
            buttonNext.Image = Properties.Resources.trianglenext; // Промяна на изображението на бутона
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e) // При въвеждане на текст в текстовото поле за име се проверява дали е празно
        {
            if (textBox_Name.Text != "") // Проверка дали текстовото поле за име не е празно
            {
                buttonNext.Visible = true; // Показване на бутона за следваща страница
            }
            else
            {
                buttonNext.Visible = false; // Скриване на бутона за следваща страница
            }
        }
        private void male_Click(object sender, EventArgs e) // Метод при натискане на бутона за мъжки пол
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                maleButton.Image = Properties.Resources.malepressed1; // Промяна на изображението на бутона на натиснато състояние
                femaleButton.Image = Properties.Resources.female1; // Промяна на изображението на бутона на нормално състояние
                male_Clicked = true; // Променя променливата за натиснато състояние на бутона за мъжки пол на true
                female_Clicked = false; // Променя променливата за натиснато състояние на бутона за женски пол на false
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                maleButton.Image = Properties.Resources.malepressedbg; // Промяна на изображението на бутона на натиснато състояние
                femaleButton.Image = Properties.Resources.femalebg; // Промяна на изображението на бутона на нормално състояние
                male_Clicked = true; // Променя променливата за натиснато състояние на бутона за мъжки пол на true
                female_Clicked = false; // Променя променливата за натиснато състояние на бутона за женски пол на false
            }
        }

        private void female_Click(object sender, EventArgs e) // Метод при натискане на бутона за женски пол
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                femaleButton.Image = Properties.Resources.femalepressed1; // Промяна на изображението на бутона на натиснато състояние
                maleButton.Image = Properties.Resources.male1; // Промяна на изображението на бутона на нормално състояние
                female_Clicked = true; // Променя променливата за натиснато състояние на бутона за женски пол на true
                male_Clicked = false; // Променя променливата за натиснато състояние на бутона за мъжки пол на false
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                femaleButton.Image = Properties.Resources.femalepressedbg; // Промяна на изображението на бутона на натиснато състояние
                maleButton.Image = Properties.Resources.malebg; // Промяна на изображението на бутона на нормално състояние
                female_Clicked = true; // Променя променливата за натиснато състояние на бутона за женски пол на true
                male_Clicked = false; // Променя променливата за натиснато състояние на бутона за мъжки пол на false
            }
        }

        private void male_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за мъжки пол се анимира чрез снимка (Правена чрез Photoshop)
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!male_Clicked) // Проверка дали бутона за мъжки пол не е натиснат
                {
                    maleButton.Image = Properties.Resources.maletracked1; // Промяна на изображението на бутона ( анимация )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!male_Clicked) // Проверка дали бутона за мъжки пол не е натиснат
                {
                    maleButton.Image = Properties.Resources.maletrackedbg; // Промяна на изображението на бутона ( анимация )
                }
            }
        }

        private void female_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за женски пол се анимира чрез снимка (Правена чрез Photoshop)
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!female_Clicked) // Проверка дали бутона за женски пол не е натиснат
                {
                    femaleButton.Image = Properties.Resources.femaletracked1; // Промяна на изображението на бутона ( анимация )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!female_Clicked) // Проверка дали бутона за женски пол не е натиснат
                {
                    femaleButton.Image = Properties.Resources.femaletrackedbg; // Промяна на изображението на бутона ( анимация )
                }
            }
        }

        private void male_MouseLeave(object sender, EventArgs e) // При излизане на мишката от бутона за мъжки пол се връща в нормално състояние
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!male_Clicked) // Проверка дали бутона за мъжки пол не е натиснат
                {
                    maleButton.Image = Properties.Resources.male1; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!male_Clicked) // Проверка дали бутона за мъжки пол не е натиснат
                {
                    maleButton.Image = Properties.Resources.malebg; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
        }

        private void female_MouseLeave(object sender, EventArgs e) // При излизане на мишката от бутона за женски пол се връща в нормално състояние
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!female_Clicked) // Проверка дали бутона за женски пол не е натиснат
                {
                    femaleButton.Image = Properties.Resources.female1; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!female_Clicked) // Проверка дали бутона за женски пол не е натиснат
                {
                    femaleButton.Image = Properties.Resources.femalebg; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
        }

        private void timerage1_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (helloPanel.Width <= 451) // Проверка дали ширината на панела е по-малка от 378
            {
                helloPanel.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (helloPanel.Width >= 451) // Проверка дали ширината на панела  е по-голяма от 378
            {
                timerAge1.Enabled = false; // Изключване на таймера
                timerAge2.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerage2_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (ageGenderPanel1.Width <= 427) // Проверка дали ширината на панела е по-малка от 427
            {
                ageGenderPanel1.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (ageGenderPanel1.Width >= 427) // Проверка дали ширината на панела е по-голяма от 427
            {
                timerAge2.Enabled = false; // Изключване на таймера
                timerAge3.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerage3_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (ageGenderPanel2.Width <= 174) // Проверка дали ширината на панела е по-малка от 121
            {
                ageGenderPanel2.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (ageGenderPanel2.Width >= 174) // Проверка дали ширината на панела е по-голяма от 121
            {
                timerAge3.Enabled = false; // Изключване на таймера
                textBox_Age.Visible = true; // Показване на текстовото поле за въвеждане на възраст
                timerAge4.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerage4_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (ageGenderPanel3.Width <= 147) // Проверка дали ширината на панела е по-малка от 147
            {
                ageGenderPanel3.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (ageGenderPanel3.Width >= 147) // Проверка дали ширината на панела е по-голяма от 147
            {
                timerAge4.Enabled = false; // Изключване на таймера
                timerAge5.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerWeight1_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (weightHeightPanel1.Width <= 320) // Проверка дали ширината на панела е по-малка от 320
            {
                weightHeightPanel1.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (weightHeightPanel1.Width >= 320) // Проверка дали ширината на панела е по-голяма от 320
            {
                timerWeight1.Enabled = false; // Изключване на таймера
                timerWeight2.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerWeight2_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (weightHeightPanel2.Width <= 420) // Проверка дали ширината на панела е по-малка от 420
            {
                weightHeightPanel2.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (weightHeightPanel2.Width >= 420) // Проверка дали ширината на панела е по-голяма от 420
            {
                timerWeight2.Enabled = false; // Изключване на таймера
                timerWeight3.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerWeight3_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (weightHeightPanel3.Width <= 180) // Проверка дали ширината на панела е по-малка от 180
            {
                weightHeightPanel3.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (weightHeightPanel3.Width >= 180) // Проверка дали ширината на панела е по-голяма от 180
            {
                timerWeight3.Enabled = false; // Изключване на таймера
                textBox_Weight.Visible = true; // Показване на текстовото поле за въвеждане на тегло
                timerWeight4.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerWeight4_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (weightHeightPanel4.Width <= 149) // Проверка дали ширината на панела е по-малка от 130
            {
                weightHeightPanel4.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (weightHeightPanel4.Width >= 149) // Проверка дали ширината на панела е по-голяма от 130
            {
                timerWeight4.Enabled = false; // Изключване на таймера
                textBox_Height.Visible = true; // Показване на текстовото поле за въвеждане на височина
                timerWeight5.Enabled = true; // Включване на следващия таймер
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e) // Метод при натискането на бутона за цел Bulk
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                buttonBulk.Image = Properties.Resources.gainPressed; // Промяна на изображението на бутона на натиснато състояние
                buttonCut.Image = Properties.Resources.loseNormal; // Промяна на изображението на бутона на нормално състояние
                buttonMaintain.Image = Properties.Resources.maintainNormal; // Промяна на изображението на бутона на нормално състояние
                bulk_Clicked = true; // Променя променливата за натиснато състояние на бутона за цел Bulk на true
                maintain_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Maintain на false
                cut_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Cut на false
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                buttonBulk.Image = Properties.Resources.gainPressedbg; // Промяна на изображението на бутона на натиснато състояние
                buttonCut.Image = Properties.Resources.loseNormalbg; // Промяна на изображението на бутона на нормално състояние
                buttonMaintain.Image = Properties.Resources.maintainNormalbg; // Промяна на изображението на бутона на нормално състояние
                bulk_Clicked = true; // Променя променливата за натиснато състояние на бутона за цел Bulk на true
                maintain_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Maintain на false
                cut_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Cut на false
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Метод при натискането на бутона за цел Cut
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                buttonBulk.Image = Properties.Resources.gainNormal; // Промяна на изображението на бутона на нормално състояние
                buttonCut.Image = Properties.Resources.losePressed; // Промяна на изображението на бутона на натиснато състояние
                buttonMaintain.Image = Properties.Resources.maintainNormal; // Промяна на изображението на бутона на нормално състояние
                bulk_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Bulk на false
                maintain_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Maintain на false
                cut_Clicked = true; // Променя променливата за натиснато състояние на бутона за цел Cut на true
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                buttonBulk.Image = Properties.Resources.gainNormalbg; // Промяна на изображението на бутона на нормално състояние
                buttonCut.Image = Properties.Resources.losePressedbg; // Промяна на изображението на бутона на натиснато състояние
                buttonMaintain.Image = Properties.Resources.maintainNormalbg; // Промяна на изображението на бутона на нормално състояние
                bulk_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Bulk на false
                maintain_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Maintain на false
                cut_Clicked = true; // Променя променливата за натиснато състояние на бутона за цел Cut на true
            }
        }

        private void buttonMaintain_Click(object sender, EventArgs e) // Метод при натискането на бутона за цел Maintain
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                buttonBulk.Image = Properties.Resources.gainNormal; // Промяна на изображението на бутона на нормално състояние
                buttonCut.Image = Properties.Resources.loseNormal; // Промяна на изображението на бутона на нормално състояние
                buttonMaintain.Image = Properties.Resources.maintainPressed; // Промяна на изображението на бутона на натиснато състояние
                bulk_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Bulk на false
                maintain_Clicked = true; // Променя променливата за натиснато състояние на бутона за цел Maintain на true
                cut_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Cut на false
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                buttonBulk.Image = Properties.Resources.gainNormalbg; // Промяна на изображението на бутона на нормално състояние
                buttonCut.Image = Properties.Resources.loseNormalbg; // Промяна на изображението на бутона на нормално състояние
                buttonMaintain.Image = Properties.Resources.maintainPressedbg; // Промяна на изображението на бутона на натиснато състояние
                bulk_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Bulk на false
                maintain_Clicked = true; // Променя променливата за натиснато състояние на бутона за цел Maintain на true
                cut_Clicked = false; // Променя променливата за натиснато състояние на бутона за цел Cut на false
            }
        }

        private void buttonCut_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за цел Cut се анимира чрез снимка (Правена чрез Photoshop)
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!cut_Clicked) // Проверка дали бутона за цел Cut не е натиснат
                {
                    buttonCut.Image = Properties.Resources.loseTracked; // Промяна на изображението на бутона ( анимация )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!cut_Clicked) // Проверка дали бутона за цел Cut не е натиснат
                {
                    buttonCut.Image = Properties.Resources.loseTrackedbg; // Промяна на изображението на бутона ( анимация )
                }
            }
        }

        private void buttonCut_MouseLeave(object sender, EventArgs e) // При излизане на мишката от бутона за цел Cut се връща в нормално състояние
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!cut_Clicked) // Проверка дали бутона за цел Cut не е натиснат
                {
                    buttonCut.Image = Properties.Resources.loseNormal; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!cut_Clicked) // Проверка дали бутона за цел Cut не е натиснат
                {
                    buttonCut.Image = Properties.Resources.loseNormalbg; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
        }

        private void buttonMaintain_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за цел Maintain се анимира чрез снимка (Правена чрез Photoshop)
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!maintain_Clicked) // Проверка дали бутона за цел Maintain не е натиснат
                {
                    buttonMaintain.Image = Properties.Resources.maintainTracked; // Промяна на изображението на бутона ( анимация )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!maintain_Clicked) // Проверка дали бутона за цел Maintain не е натиснат
                {
                    buttonMaintain.Image = Properties.Resources.maintainTrackedbg; // Промяна на изображението на бутона ( анимация )
                }
            }
        }

        private void buttonMaintain_MouseLeave(object sender, EventArgs e) // При излизане на мишката от бутона за цел Maintain се връща в нормално състояние
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!maintain_Clicked) // Проверка дали бутона за цел Maintain не е натиснат
                {
                    buttonMaintain.Image = Properties.Resources.maintainNormal; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!maintain_Clicked) // Проверка дали бутона за цел Maintain не е натиснат
                {
                    buttonMaintain.Image = Properties.Resources.maintainNormalbg; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
        }

        private void buttonBulk_MouseEnter(object sender, EventArgs e) // При преминаване на мишката върху бутона за цел Bulk се анимира чрез снимка (Правена чрез Photoshop)
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!bulk_Clicked) // Проверка дали бутона за цел Bulk не е натиснат
                {
                    buttonBulk.Image = Properties.Resources.gainTracked; // Промяна на изображението на бутона ( анимация )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!bulk_Clicked) // Проверка дали бутона за цел Bulk не е натиснат
                {
                    buttonBulk.Image = Properties.Resources.gainTrackedbg; // Промяна на изображението на бутона ( анимация )
                }
            }
        }

        private void buttonBulk_MouseLeave(object sender, EventArgs e) // При излизане на мишката от бутона за цел Bulk се връща в нормално състояние
        {
            var config = new Config("FitVitality.ini"); // Създаване на обект от класа Config за четене и писане във файла FitVitality.ini (конфигурационен файл)
            if (config.Read("Language", "SETTINGS") == "en")
            {
                if (!bulk_Clicked) // Проверка дали бутона за цел Bulk не е натиснат
                {
                    buttonBulk.Image = Properties.Resources.gainNormal; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
            if (config.Read("Language", "SETTINGS") == "bg")
            {
                if (!bulk_Clicked) // Проверка дали бутона за цел Bulk не е натиснат
                {
                    buttonBulk.Image = Properties.Resources.gainNormalbg; // Промяна на изображението на бутона ( нормално състояние )
                }
            }
        }

        private void timerGoal1_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на цел
        {
            if (goalPanel1.Width <= 278) // Проверка дали ширината на панела е по-малка от 278
            {
                goalPanel1.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (goalPanel1.Width >= 278) // Проверка дали ширината на панела е по-голяма от 278
            {
                timerGoal1.Enabled = false; // Изключване на таймера
                timerGoal2.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerGoal2_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на цел
        {
            if (goalsPanel.Height <= 133) // Проверка дали височината на панела е по-малка от 133
            {
                goalsPanel.Height += 6; // Увеличаване на височината на панела с 6
            }
            if (goalsPanel.Height >= 133) // Проверка дали височината на панела е по-голяма от 133
            {
                timerGoal2.Enabled = false; // Изключване на таймера
                timerLabel.Visible = true; // Показване на надписа, служещ за индикатор на анимациите
                buttonDone.Visible = true; // Показване на бутона за завършване на регистрацията
            }
        }

        private void timerWeight5_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (info2_Panel.Width <= 222) // Проверка дали ширината на панела е по-малка от 179
            {
                info2_Panel.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (info2_Panel.Width >= 222) // Проверка дали ширината на панела е по-голяма от 179
            {
                timerWeight5.Enabled = false; // Изключване на таймера
                timerWeight6.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerWeight6_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (info1_Panel.Width <= 309) // Проверка дали ширината на панела е по-малка от 309
            {
                info1_Panel.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (info1_Panel.Width >= 309) // Проверка дали ширината на панела е по-голяма от 309
            {
                timerWeight6.Enabled = false; // Изключване на таймера
                timerWeight7.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerWeight7_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на тегло и височина
        {
            if (info3_Panel.Width <= 309) // Проверка дали ширината на панела е по-малка от 309
            {
                info3_Panel.Width += 6; // Увеличаване на ширината на панела с 6
            }
            if (info3_Panel.Width >= 309) // Проверка дали ширината на панела е по-голяма от 309
            {
                timerWeight7.Enabled = false; // Изключване на таймера
                timerLabel2.Visible = true; // Показване на надписа, служещ за индикатор на анимациите
            }
        }

        private void timerAge5_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (genderPanel.Height <= 40) // Проверка дали височината на панела е по-малка от 40
            {
                genderPanel.Height += 5; // Увеличаване на височината на панела с 5
            }
            if (genderPanel.Height >= 40) // Проверка дали височината на панела е по-голяма от 40
            {
                timerAge5.Enabled = false; // Изключване на таймера
                timerAge6.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerAge6_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (info1_ageGender_Panel.Width <= 309) // Проверка дали ширината на панела е по-малка от 309
            {
                info1_ageGender_Panel.Width += 5; // Увеличаване на ширината на панела с 5
            }
            if (info1_ageGender_Panel.Width >= 309) // Проверка дали ширината на панела е по-голяма от 309
            {
                timerAge6.Enabled = false; // Изключване на таймера
                timerAge7.Enabled = true; // Включване на следващия таймер
            }
        }

        private void timerAge7_Tick(object sender, EventArgs e) // Таймер за анимация на страницата за въвеждане на възраст и пол
        {
            if (info2_ageGender_Panel.Width <= 309) // Проверка дали ширината на панела е по-малка от 309
            {
                info2_ageGender_Panel.Width += 5; // Увеличаване на ширината на панела с 5
            }
            if (info2_ageGender_Panel.Width >= 309) // Проверка дали ширината на панела е по-голяма от 309
            {
                timerAge7.Enabled = false; // Изключване на таймера
                timerLabel3.Visible = true; // Показване на надписа, служещ за индикатор на анимациите
            }
        }

        private void timerName3_Tick(object sender, EventArgs e)
        {
            if (panel_nameUsage.Width <= 509) // Проверка дали ширината на панела е по-малка от 482
            {
                panel_nameUsage.Width += 8; // Увеличаване на ширината на панела с 8
            }
            if (panel_nameUsage.Width >= 509)
            {
                timerName3.Enabled = false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
        }

        private void errorClose_MouseEnter(object sender, EventArgs e)
        {
            errorClose.BackColor = Color.IndianRed;
        }

        private void errorClose_MouseLeave(object sender, EventArgs e)
        {
            errorClose.BackColor = Color.WhiteSmoke;
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
