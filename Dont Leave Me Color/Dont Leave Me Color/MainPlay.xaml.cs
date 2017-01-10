using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Dont_Leave_Me_Color
{
    /// <summary>
    /// Interaction logic for MainPlay.xaml
    /// </summary>
    public partial class MainPlay : Page
    {
        public MainPlay()
        {
            InitializeComponent();
        }

        /***สร้างตัวแปรสำหรับใช้ในทุก Function***/
        bool level = true;
        bool gameEnd = false;
        int nextTime = 0;
        int score = 0;
        int life = 5;
        int ten = 10;
        int thisLevel = 1;
        public static string var;
        public static string var2;
        public static string r;
        public static string g;
        public static string b;
        Byte intR;
        Byte intG;
        Byte intB;

        Random rd = new Random();                           // สร้างตัว Random
        tapControl[] a = new tapControl[1024];              // สร้างตัวกลางเพื่อสร้างสี
        ColorClass z = new ColorClass();                    // ดึงตัวแปรกลาง
        DispatcherTimer timeTap = new DispatcherTimer();    // สร้างตัวจับเวลา
        TimeSpan timeMusic = new TimeSpan(0, 3, 27);        // สร้างตัวจับเวลาของเพลง
        /*-----------------------------------------------------------------------*/

        // Function ที่สามารถดึงไฟล์จาก .C มาใช้พัฒนาใน C#
        public static void callFuntionC(int cases, int number)
        {
            string dir = Environment.CurrentDirectory;
            ProcessStartInfo info = new ProcessStartInfo();
            Process process = new Process();
            info.FileName = dir + "\\FunctionC.exe"; //เรียกไฟล์ .exe จากไฟล์ของ .C ที่ Compile แล้ว
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;      // ทำให้ไฟล์สามารถส่ง Output ได้
            info.RedirectStandardInput = true;       // ทำให้ไฟล์สามารถรับ Input ได้
            info.CreateNoWindow = true;              // ปิดการเปิด cmd
            process.StartInfo = info;
            process.Start();                         // เข้าไฟล์ .exe

            //ส่ง Input เข้าไฟล์ .C ด้วย process.StandardInput.WriteLine(...)
            //รับ Output จากไฟล์ .C ด้วย MainPlay.variable = process.StandardOutput.ReadLine(); <== ออกมาเป็น String
            if (cases == 1)
            {
                process.StandardInput.WriteLine(cases);
                process.StandardInput.WriteLine(number);
                MainPlay.var = process.StandardOutput.ReadLine();
            }
            else if (cases == 2)
            {
                process.StandardInput.WriteLine(cases);
                process.StandardInput.WriteLine(number);
                MainPlay.var2 = process.StandardOutput.ReadLine();
            }
            else if (cases == 3)
            {
                process.StandardInput.WriteLine(cases);
                process.StandardInput.WriteLine(number);
                MainPlay.r = process.StandardOutput.ReadLine();
                MainPlay.g = process.StandardOutput.ReadLine();
                MainPlay.b = process.StandardOutput.ReadLine();
            }
            process.WaitForExit();
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function เมื่อเปิดหน้าจอ Application ขึ้นมา
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            this.Focus();   // ให้ Focus ที่จอของ Application จะสามารถทำให้ Object สามารถเคลื่อนที่ได้
            music.Play();   // เล่นเพลงในเกม
            scoreText.Text = "Score: "+score;
            lifeText.Text = "LIFE: " +life ;

            // เมื่อเริ่มต้นโปรแกรม ให้เริ่มต้นเกมด้วย Level 1
            if (level)
            {
                levelUP();
                level = false;
            }

            //นาฬิกาจับเวลา โดยให้ Function tap_bot ทำงานทุกๆ 16.67 milliseconds
            timeTap.Tick += new EventHandler(tap_bot);
            timeTap.Interval = new TimeSpan(0, 0, 0, 0, 1000/60); // <= 60 FPS ทำให้ภาพลื่น
            timeTap.Start();
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function ใน
        private void tap_bot(object sender, EventArgs e)
        {
            // เมื่อเพลงจบ ให้เริ่มเพลงใหม่
            if (music.Position == timeMusic)
            {
                music.Position = TimeSpan.Zero;
                music.Play();
            }

            // หน่วงเวลาการสร้างสี
            if (nextTime <= 0)
            {
                nextTime = rd.Next(10, 30); //สุ่มตัวเลขมา เพื่อเพิ่มหรือลดจำนวนความถี่ของสีที่หล่นลงมา

                // สุ่มตัวเลขมา เพื่อนำไปสร้างสีให้หล่นลงมา
                int note1 = rd.Next(0, 5);
                int note2 = rd.Next(0, 5);
                int note3 = rd.Next(0, 5);
                int note4 = rd.Next(0, 5);

                // ถ้าในแถบใดแถบหนึ่งที่สุ่มได้ = 1 จะเข้าเงื่อนไขในการสร้างสี
                if (note1 == 1) makeKey(0);
                if (note2 == 1) makeKey(1);
                if (note3 == 1) makeKey(2);
                if (note4 == 1) makeKey(3);
            }
            nextTime--;

            // เพิ่มความเร็ว (Speed) ทุกๆ 5+(n*2) โดย n = Level
            int speed = 5 + (thisLevel * 2);

            // หลังจากสร้างสี เสร็จจะเข้าสู่ Loop นี้เพื่อตั้งค่า
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != null)
                {
                    // ตั้งค่าให้สีร่วงลงมาตามแกน Y เรื่อยๆ โดยใช้ Speed
                    a[i].y += speed; 
                    Canvas.SetTop(a[i], a[i].y);

                    // ถ้าร่วงลงมามากกว่าหรือเท่ากับ 550 Pixel สีจะถูกลบออก
                    if (a[i].y >= 550)
                    {
                        removeKey(i);
                    }
                }
            }
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function ในการสร้างสี
        private void makeKey(int n)
        {
            for (int i = 0; i < a.Length; i++)
            {
                // ตั้งค่าให้กับสี
                if (a[i] == null)
                {
                    a[i] = new tapControl(); // สร้าง Object ของสีใหม่ทุกครั้ง
                    a[i].x = 0;              // กำหนดตำแหน่งของสีในแกน X
                    a[i].y = 0;              // กำหนดตำแหน่งของสีในแกน Y
                    a[i].note = n;           // กำหนดว่าให้สีหล่นในแถบ 1 หรือ 2 หรือ 3 หรือ 4

                    int number = rd.Next(0, 7); // สุ่มตัวเลข เพื่อนำตัวเลขไปเรียก Index ของสีใน Base
                    callFuntionC(1, number);    // เรียก Function เพื่อไปเรียก Base ของสี
                    a[i].thisTouch = var;       // เก็บชื่อของสี

                    int randomCCC = rd.Next(1, 3); // สุ่มตัวเลข เพื่อนำตัวเลขไปเรียกชื่อไฟล์ของรูปสี บางสีมี 2 ไฟล์ เช่น สีน้ำเงิน
                    if (var == "Black" || var == "Yellow") // มีเพียงสีดำและสีเหลืองที่มี ไฟล์เดียว
                    {
                        a[i].bg.Source = new BitmapImage(new Uri("Pic/Colours/" + var + ".png", UriKind.RelativeOrAbsolute));
                    }
                    else // นอกจากนั้นให้เอาเลขที่สุ่มมาได้ มาเขียนลงท้ายชื่อไฟล์รูปสี เช่น Blue1
                    {
                        a[i].bg.Source = new BitmapImage(new Uri("Pic/Colours/" + var + randomCCC + ".png", UriKind.RelativeOrAbsolute));
                        
                    }

                    // Set ค่าตำแหน่งของสีออกทางหน้าจอ
                    Canvas.SetTop(a[i], a[i].y);
                    Canvas.SetLeft(a[i], a[i].x);

                    // เพิ่มสีเข้าไปในแทบ 1 หรือ 2 หรือ 3 หรือ 4
                    switch (n)
                    {
                        case 0:
                            tap1.Children.Add(a[i]);
                            break;
                        case 1:
                            tap2.Children.Add(a[i]);
                            break;
                        case 2:
                            tap3.Children.Add(a[i]);
                            break;
                        case 3:
                            tap4.Children.Add(a[i]);
                            break;
                    }
                    return;
                }
            }
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function ลบสี
        private void removeKey(int index)
        {
            switch (a[index].note)
            {
                case 0:
                    tap1.Children.Remove(a[index]);
                    a[index] = null;
                    break;
                case 1:
                    tap2.Children.Remove(a[index]);
                    a[index] = null;
                    break;
                case 2:
                    tap3.Children.Remove(a[index]);
                    a[index] = null;
                    break;
                case 3:
                    tap4.Children.Remove(a[index]);
                    a[index] = null;
                    break;
            }
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function เพิ่มคะแนน
        private void addScore()
        {
            // ถ้ากดถูกเงื่อนไขจะ +1 คะแนน
            score++;
            scoreText.Text = "Score: "+score;
            // ถ้าคะแนนได้ครบตามเงื่อนไข จะได้เลื่อน Level
            if (score == ten)
            {
                levelUP(); // เรียก Function เพื่อเลื่อน Level
                ten *= 2;
            }
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function ลบพลังชีวิต
        private void removeScore()
        {
            // ถ้ากดสีที่ตรงกับเงื่อนไขที่ห้าม ก็จะถูกลบ 1 พลังชีวิต
            life--;

            // ถ้าคะแนนชีวิตเหลือ = 0 จะทำให้ Game Over
            if (life == 0)
            {
                Storyboard mystory = new Storyboard();
                mystory = (Storyboard)this.Resources["storyOver"];
                mystory.Begin(this);
                timeTap.Stop();
                yourScoreText.Text = "Your Score: " + score;
                gameEnd = true;
                music.Stop();
                gameOverSound.Play();

            }
            lifeText.Text = "LIFE: "+life;
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Funtion เลื่อน Level ใหม่
        private void levelUP()
        {
            HashSet<int> set = new HashSet<int>(); // สร้าง Set เพื่อเก็บตัวเลข เพราะ Set จะไม่เก็บตัวเลขตัวซ้ำ
            while (set.Count < 4)
            {
                Random rd = new Random();
                set.Add(rd.Next(0, 6));
            }

            int randomTapColor = rd.Next(0, 7); // สุ่มตัวเลข เพื่อนำตัวเลขไปเรียก Index ของรูปสีมาใช้ในแถบกด
            callFuntionC(2, randomTapColor);    // เรียก Function เพื่อดึงสี จาก Base
            z.dontTouch = var2;                 
            dont.Text = z.dontTouch;            // แสดงข้อความของสีที่ห้ามกด

            int test = 0;

            // เปลี่ยนสีของแถบกด
            // Byte.Parse(...) --> แปลงตัวเลขฐาน 10 เป็น Byte (ฐาน 2) เพื่อนำมาเรียกสีใน RGB
            foreach (int c in set)
            {
                callFuntionC(3, c);
                intR = Byte.Parse(r);
                intG = Byte.Parse(g);
                intB = Byte.Parse(b);
                switch (test)
                {
                    case 0:
                        click1.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB));
                        c1.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB)); break;
                    case 1:
                        click2.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB));
                        c2.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB)); break;
                    case 2:
                        click3.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB));
                        c3.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB)); break;
                    case 3:
                        click4.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB));
                        c4.Background = new SolidColorBrush(Color.FromRgb(intR, intG, intB)); break;
                }
                test++;
            }
            levelText.Text = "LEVEL: " + thisLevel;
            thisLevel++; // เพิ่ม Level
            return;
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function เมื่อปุ่มใน KeyBoard ถูกกดลง
        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            // ถ้ากดปุ่ม Enter ในขณะที่ Game Over จะกลับไปหน้าแรก
            if (e.Key == Key.Enter && gameEnd == true)
            {
                this.NavigationService.Navigate(new Uri("MainMenu.xaml", UriKind.RelativeOrAbsolute));
                gameEnd = false;
            }
            soundTap.Stop();

            // Array ของปุ่มที่จะใช้ในการกด เช่นแถบที่ 1 ปุ่ม D, 2:F, 3:J, 4:K
            Key[] key = { Key.D, Key.F, Key.J, Key.K }; 

            for (int i = 0; i < a.Length; i++)
            {
                // ถ้าปุ่มใดปุ่มหนึ่งถูกกดจะเพิ่มความโปร่งใสของแถบกด 100% (สีเข้ม)
                // ถ้าปุ่มใดปุ่มหนึ่งถูกกดจะลดความโปร่งใสของแถบเลื่อนเหลือ 15% (สีอ่อน)
                switch (e.Key)
                {
                    case Key.D:
                        click1.Opacity = 1;
                        c1.Opacity = .15;
                        soundTap.Play();
                        break;
                    case Key.F:
                        click2.Opacity = 1;
                        c2.Opacity = .15;
                        soundTap.Play();
                        break;
                    case Key.J:
                        click3.Opacity = 1;
                        c3.Opacity = .15;
                        soundTap.Play();
                        break;
                    case Key.K:
                        click4.Opacity = 1;
                        c4.Opacity = .15;
                        soundTap.Play();
                        break;
                }
                if (a[i] != null)
                {
                    // ถ้าปุ่มถูกกดตรงกับสีที่ร่วงลงมาในแต่ละแถบจะทำการเช็คว่าเรากดก่อนถึงแถบหรือกดหลังแถบ
                    if (e.Key == key[a[i].note])
                    {
                        if (a[i].y < 550 && a[i].y >= 400) //ถ้ากดภายในแถบก็จะเช็คอีกว่า ถูกเงื่อนไขของสีหรือไม่
                        {
                            if (a[i].thisTouch == z.dontTouch) removeScore(); // ถ้ากดตรงกับเงื่อนไขห้ามกดสีก็จะเข้า Function ลบพลังชีวิต
                            else addScore(); // แต่ถ้าไม่ก็จะเข้า Function เพิ่มคะแนน
                            removeKey(i);    // เข้า Function เพื่อลบ Object สี
                        }
                    }
                }
            }
        }
        /*-------------------------------------------------------------------------------------*/

        // เป็น Function เมื่อปุ่มที่เรากดแล้วปล่อย
        private void Page_KeyUp(object sender, KeyEventArgs e)
        {
            // ถ้าปุ่มใดปุ่มหนึ่งถูกปล่อยจะลดความโปร่งใสของแถบกดเหลือ 30% (สีอ่อน)
            // ถ้าปุ่มใดปุ่มหนึ่งถูกปล่อยจะลดความโปร่งใสของแถบเลื่อนเหลือ 0% (จางหาย)
            switch (e.Key)
            {
                case Key.D:
                    click1.Opacity = .3;
                    c1.Opacity = 0;
                    break;
                case Key.F:
                    click2.Opacity = .3;
                    c2.Opacity = 0;
                    break;
                case Key.J:
                    click3.Opacity = .3;
                    c3.Opacity = 0;
                    break;
                case Key.K:
                    click4.Opacity = .3;
                    c4.Opacity = 0;
                    break;
            }
        }
        /*-------------------------------------------------------------------------------------*/
    }
}
