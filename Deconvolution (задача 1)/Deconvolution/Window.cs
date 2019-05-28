using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

//программа реализует решение некорректной задачи восстановления сигнала по его свертке
//решение прохожит по методу максимума энтропии
//мы строим сигнал, его импульсную характеристику, находим свертку, и из уравнения функционала энтропии получаем систему уравнений, которую нужно приближенно решить
//при помощи метода Хука-Дживса, путем постоянной оптимизации выведенного нами функционала
//каждая итерация метода приближает сигнал к исходному, пока не будет достигнута заданная точность
//каждая итерация выводится на экран, создавая таким образом анимацию процесса восстановления

namespace Deconvolution
{
    public partial class Deconvolution : MaterialForm
    {
        int arraysize, iterate, timer_iterate, noise;

        //переменные метода Хука-Дживса
        int j, bs, ps;
        double z, h, k, fi, fb;
        //float TAU = 1e-8f; // Точность вычислений
        double TAU; // Точность вычислений
        double Epsilon;
        double[] b;
        double[] fix;
        double[] p;

        
        double currentfunc, square; //значение функционала и квадрат отклонения

        bool animation, initiate, stop_animation;

        double[] Y;//Массив игрeков
        double[] Convol;//Массив свертки
        double[] Imp;//Массив импульсной характеристики
        double[] Lambda;//массив множителей Лагранжа
        double[] Renown; //массив восстановленного сигнала
		
		//массивы данных с экрана
        double[] ArrayAmplitude; //амплитуды
        double[] ArrayCenters; //центры
        double[] ArrayDisp; //дисперсии
        Random rand = new Random();

        double Disp_H, Amp_H; //амплитуда и дисперсия для импульсной характеристики

        public Deconvolution()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800,
                Primary.Cyan900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
			
			//выделяем пасять под массивы данных с экрана
            ArrayAmplitude = new double[3];
            ArrayCenters = new double[3];
            ArrayDisp = new double[3];

			//задаем степень точность
            Epsilon = Math.Pow(10, TAU);

            animation = initiate = true;
            iterate = 0;
            currentfunc = 0;
            square = 0;

            InitializeComponent();
        }
		
		//функция инициализации (ввод в массивы необходимых данных, выделение памяти под прочие массивы)
        void InitiateModel()
        {
            ArrayAmplitude[0] = Convert.ToDouble(amp1.Text);
            ArrayAmplitude[1] = Convert.ToDouble(amp2.Text);
            ArrayAmplitude[2] = Convert.ToDouble(amp3.Text);
            ArrayCenters[0] = Convert.ToDouble(center1.Text);
            ArrayCenters[1] = Convert.ToDouble(center2.Text);
            ArrayCenters[2] = Convert.ToDouble(center3.Text);
            ArrayDisp[0] = Convert.ToDouble(disp1.Text);
            ArrayDisp[1] = Convert.ToDouble(disp2.Text);
            ArrayDisp[2] = Convert.ToDouble(disp3.Text);
            Disp_H = Convert.ToDouble(dispH.Text);
            Amp_H = Convert.ToDouble(ampH.Text);

            arraysize = Convert.ToInt32(array.Text);
            timer_iterate = Convert.ToInt32(TimerIterateText.Text);
            noise = Convert.ToInt32(NoiseText.Text);
            TAU = Convert.ToDouble(EpsilonText.Text);
            
            Epsilon = Math.Pow(10, TAU);

            Y = new double[arraysize];
            Imp = new double[arraysize];
            Convol = new double[arraysize];
            Lambda = new double[arraysize];
            Renown = new double[arraysize];

            b = new double[arraysize];
            fix = new double[arraysize];
            p = new double[arraysize];
        }
       
	    //функция для графика (по условию задачи рисуются гауссовы купола)
        private double GaussFunc(double step, double[] Amp, double[] Center, double[] Disp)
        {
            double result = 0;
            for (int i = 0; i < 3; i++)
            {
                result += Amp[i] * Math.Exp(-((step - Center[i]) * (step - Center[i])) / (Disp[i] * Disp[i]));
            }
            return result;
        }
		
		//функция импульсной характеристики (также гауссов купол по условию)
        private double Impulse(double step, double Disp_H, double Amp_H)
        {
            return (Amp_H * Math.Exp(-(step * step) / (Disp_H * Disp_H)));
        }

		//функция начальной инициализации метода Хука-Дживса (в частности заполняем массив множителей Лагранжа Lambda)
        void InitiateMHJ()
        {
            h = 1.0f;
            Lambda[0] = 1.0f;

            for (int i = 1; i < arraysize; i++)
            {
                Lambda[i] = 0; // Задается начальное приближение
            }

            k = h;
            for (int i = 0; i < arraysize; i++)
            {
                fix[i] = p[i] = b[i] = Lambda[i];
            }

            fi = function(Lambda);
            ps = 0;
            bs = 1;
            fb = fi;

            j = 0;
        }
		
		//см метод Хука-Дживса
        void MHJ()
        {
            while (j < arraysize)
            {
                //calc++; // Счетчик итераций. Можно игнорировать

                Lambda[j] = fix[j] + k;
                z = function(Lambda);
                if (z >= fi)
                {
                    Lambda[j] = fix[j] - k;
                    z = function(Lambda);

                    if (z < fi)
                        fix[j] = Lambda[j];
                    else
                        Lambda[j] = fix[j];
                }
                else fix[j] = Lambda[j];

                fi = function(Lambda);
                currentfunc = fi;
                j++;
            }

            if (fi + 1e-8 >= fb)  
            {
	            if (ps == 1 && bs == 0) 
                {
		            for(int i = 0; i < arraysize; i++)
                    {
		                p[i] = fix[i] = Lambda[i] = b[i];
		            }
		            z = function(Lambda);
		            bs = 1;
                    ps = 0;
                    fi = z;
                    fb = z;
                    j = 0;		             
		        }

                k /= 10;

                if (k < TAU)
                {
                   stop_animation = true;
                }
                
                j = 0;

            }

	        for(int i = 0; i < arraysize; i++)  
            {
	            p[i] = 2 * fix[i] - b[i];
	            b[i] = fix[i];
	            Lambda[i] = p[i];
                fix[i] = Lambda[i];
	        }
	        z = function(Lambda);
	        fb = fi;
            ps = 1;
            bs = 0;
            fi = z;
            j = 0;

            for (int i = 0; i < arraysize; i++)
            {
                double sum = 0;
                for (int k = 0; k < arraysize; k++)
                {
                    if ((k - i) < 0)
                        sum += Lambda[k] * Imp[arraysize + (k - i) - 1];
                    else
                        sum += Lambda[k] * Imp[k - i];
                }
                Renown[i] = (float)Math.Exp(-1 - sum);
            }

            square = 0;
            for (int i = 0; i < arraysize; i++)
            {
                square += (Y[i] - Renown[i]) * (Y[i] - Renown[i]);
            }
            square /= arraysize;
        }
		
		//функционал для оптимизации
        double function(double[] Lambda)
        {
            // Реализует оптимизируемую функцию
            // Возвращает значение функции            

            double result = 0;
            double[] buf_array = new double[arraysize];

            //подсчет двух внутренних сумм функционала
            for (int n = 0; n < arraysize; n++)
            {
                double summary = 0;
                for (int k = 0; k < arraysize; k++)
                {
                    if ((k - n) < 0)
                        summary += Lambda[k] * Imp[arraysize + (k - n) - 1];
                    else
                        summary += Lambda[k] * Imp[k - n];
                }
                buf_array[n] = Math.Exp(-1 - summary);
            }

            //подсчет внешней суммы функционала
            for (int i = 0; i < arraysize; i++)
            {
                double summary = 0;
                for (int n = 0; n < arraysize; n++)
                {
                    if ((i - n) < 0)
                        summary += buf_array[n] * Imp[arraysize + (i - n) - 1];
                    else
                        summary += buf_array[n] * Imp[i - n];
                }
                result += (Convol[i] - summary) * (Convol[i] - summary);
            }

            return result;
        }
		
		//функция добавления шума к свертке (для исследования зависимости процесса восстановления от шума)
        void AddNoise(double[] array, int size, int noisePercent)
        {
            double f;

            double[] n = new double[size];
            for (int t = 0; t < size; t++)
            {
                f = 0;
                for (int j = 0; j < 20; j++)
                {
                    f += Convert.ToDouble(rand.Next(-2000, 2001)) / 2000;
                }
                n[t] = f / 20;
            }
            double shumy = 0;
            for (int t = 0; t < size; t++)
            {
                shumy += array[t] * array[t];
            }

            double shumn = 0;
            for (int t = 0; t < size; t++)
            {
                shumn += n[t] * n[t];
            }

            double noise_percent = noisePercent;
            noise_percent /= 100;
            //подсчёт коэфициента альфа
            double alfa = Math.Sqrt(noise_percent * shumy / shumn);

            for (int t = 0; t < size; t++)
            {
                array[t] = array[t] + (float)(alfa * n[t]);
            }
        }

        private void Deconvolution_Load(object sender, EventArgs e)
        {
            Reset_Click(sender, e);
        }

		//обработчик кнопки "Графики"
        private void Draw_Click(object sender, EventArgs e)
        {
            InitiateModel(); //инициализируем нашу "модель"

            Animate_Timer.Interval = timer_iterate;
            Epsilon = Math.Pow(10, TAU);

            //создаем сигнал
            for (int i = 0; i < arraysize; i++)
            {
                Y[i] = GaussFunc(i, ArrayAmplitude, ArrayCenters, ArrayDisp);
            }

            //создаем импульсную характеристику (важный момент: гауссов купол расположен по бокам от оси Y, 
			//но нам нужно разместить его в положительной части системы координат, поэтому
			//все отсчеты слева от оси перемещаем вправо, получив двойную горку вместо купола)
            for (int i = 0; i < arraysize; i++)
            {
                if (i < arraysize / 2)
                    Imp[i] = Impulse(i, Disp_H, Amp_H);
                else
                    Imp[i] = Impulse(i - arraysize, Disp_H, Amp_H);
            }
            
            //проводим свертку импульсной характеристики с исходным сигналом
            for (int i = 0; i < arraysize; i++)
            {
                Convol[i] = 0;
                for (int j = 0; j < arraysize; j++)
                {
                    if ((i - j) < 0)
                        Convol[i] += Y[j] * Imp[arraysize + (i - j)];
                    else
                        Convol[i] += Y[j] * Imp[i - j];
                }
            }

			//добавляем шум (функция вызывается всегда, но при нулевом проценте шума она ничего не поменяет, так что пусть себе вызывается каждый раз)
            AddNoise(Convol, arraysize, noise); 

			//графики русуются в соответствующих компонентах Chart, так что очищаем поля для графиков
            SourceChart.Series[0].Points.Clear();
            SourceChart.Series[1].Points.Clear();
            ImpulseChart.Series[0].Points.Clear();
            ConvolChart.Series[0].Points.Clear();
			
			//а тут рисуем графики
            for (int i = 0; i < arraysize; i++)
            {
                SourceChart.Series[0].Points.AddXY(i, Y[i]);
                ImpulseChart.Series[0].Points.AddXY(i, Imp[i]);
                ConvolChart.Series[0].Points.AddXY(i, Convol[i]);
            }

			//так как массивы данных заполнены, то можем разрешить пользователю начать процесс восстановления
            StartStop_Animate.Enabled = true;
        }

        //функция обработки таймера (анимация)
        private void Animate_Timer_Tick(object sender, EventArgs e)
        {
			//вызываем метод Хука-Дживса
            MHJ();
			
			//наращиваем переменную итерации, чтобы потом отправить ее на нижнюю панель
            iterate++;

			//очищаем поле и рисуем в нем восстановленный график
            SourceChart.Series[1].Points.Clear();
            for (int i = 0; i < arraysize; i++)
            {
                SourceChart.Series[1].Points.AddXY(i, Renown[i]);
            }
			
			//обновляем нижнюю панель
            lowBar.Items[0].Text = "счетчик итераций: " + iterate.ToString() + "    ";
            lowBar.Items[1].Text = "значение функционала: " + currentfunc.ToString() + "    ";
            lowBar.Items[2].Text = "отклонение: " + square.ToString();
			
			
			//если у нас количество итераций превысит заданное, или пользователь сам прекратит восстановление, то отключаем таймер
            if (iterate > 1000 || stop_animation == true)
            {
                Animate_Timer.Enabled = false;
            }
        }

        //кнопка "начать/остановить анимацию"
        private void StartStop_Animate_Click(object sender, EventArgs e)
        {
            if (animation == true)
            {
				//если хотим начать восстановление, то включаем таймер, и превращаем кнопку в "Остановить"
                Animate_Timer.Enabled = true;
                animation = false;
                StartStop_Animate.Text = "остановить";
            }
            else
            {
				//а здесь все наоборот: отключаем таймер, и превращаем кнопку в "Начать"
                Animate_Timer.Enabled = false;
                animation = true;
                StartStop_Animate.Text = "начать";
            }
			
			//инициализировать метод Хука-Дживса нужно лишь единожды, но при нажатии на кнопку сброса это можно сделать снова
            if (initiate == true)
            {
                InitiateMHJ();
                initiate = false;
            }
        }

        //кнопка "сброс"
        private void Reset_Click(object sender, EventArgs e)
        {
			//вообще кнопка нужна только для возможности заново проинициализировать метод Хука-Дживса, 
			//но почему бы не перерисовать заодно все графики, на всякий случай?
			
			//зануляем массивы и переменные
            for(int i = 0; i < arraysize; i++)
            {
                Y[i] = 0;
                Convol[i] = 0;
                Imp[i] = 0;
                b[i] = 0;
                fix[i] = 0;
                p[i] = 0;
                Renown[i] = 0;
            }
            square = 0;
            currentfunc = 0;
            iterate = 0;

			//ставим начальные значения логических переменных
            initiate = true;
            Animate_Timer.Enabled = false;
            animation = true;

            StartStop_Animate.Text = "начать";
			
			//сбрасываем содержание нижней панели на стандартное
            lowBar.Items[0].Text = "счетчик итераций: " + iterate.ToString() + "    ";
            lowBar.Items[1].Text = "значение функционала: " + currentfunc.ToString() + "    ";
            lowBar.Items[2].Text = "отклонение: " + square.ToString();
			
			//вызываем кнопку отрисовки, и на всякий случай запрещаем восстановление (кнопка станет доступной при повторном нажатии на кнопку "Графики")
            Draw_Click(sender, e);
            StartStop_Animate.Enabled = false;
        }
    }
}
