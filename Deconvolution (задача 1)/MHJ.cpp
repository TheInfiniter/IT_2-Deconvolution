float CP4Doc::MHJ(int kk, float* x)
{
// kk - количество параметров; x - массив параметров
  float  TAU=1.e-6f; // Точность вычислений
  int i, j, bs, ps;
  float z, h, k, fi, fb;
  float *b = new float[kk];
  float *y = new float[kk];
  float *p = new float[kk];

  h=1.;	
  x[0]=1.;
  for( i=1; i<kk; i++)  x[i]=(float)rand()/RAND_MAX; // Задается начальное приближение

  k = h;
  for( i=0; i<kk; i++)	y[i] = p[i] = b[i] = x[i];
  fi = function(x);
  ps = 0;   bs = 1;  fb = fi;

  j = 0;
  while(1)
  {
	calc++; // Счетчик итераций. Можно игнорировать

  x[j] = y[j] + k;
  z = function(x);
  if (z >= fi) {
	 x[j] = y[j] - k;
	 z = function(x);
	 if( z<fi )   y[j] = x[j];
	 else  x[j] = y[j];
	 }
  else  y[j] = x[j];
  fi = function(x);

  if ( j < kk-1 )   {  j++;  continue;  }
  if ( fi + 1e-8 >= fb )  {
	 if ( ps == 1 && bs == 0) {
		for( i=0; i<kk; i++)	 {
		  p[i] = y[i] = x[i] = b[i];
		  }
		z = function(x);
		bs = 1;   ps = 0;   fi = z;   fb = z;   j = 0;
		continue;
		}
 k /= 10.;
 if ( k < TAU ) break;
  j = 0;
  continue;
  }

	for( i=0; i<kk; i++) {
	  p[i] = 2 * y[i] - b[i];
	  b[i] = y[i];
	  x[i] = p[i];

	  y[i] = x[i];
	  }
	z = function(x);
	fb = fi;   ps = 1;   bs = 0;   fi = z;   j = 0;
  } //  end of while(1)

  for( i=0; i<kk; i++)  x[i] = p[i];

  delete b;
  delete y;
  delete p;
  return fb;
}

float CP4Doc::function(float*x)
{
// Реализует оптимизируемую функцию
// Возвращает значение функции
// количество параметров является членом класса, в противном случае изменить сигнатуру функции
//	........
	return ...;
}


private float function(float[] L) 
{ 

double functional = 0; 

double[] buffer = new double[M]; 
for (int n = 0; n < M; n++) 
	{ 
	double sum = 0; 
	for (int k = 0; k < M; k++) 
	{ 
		if ((k - n) < 0) 
			sum += L[k] * H[M + (k - n) - 1]; 
		else 
			sum += L[k] * H[k - n]; 
	} 
	buffer[k] = Math.Exp(-1 - sum); 
} 

for (int m = 0; m < M; m++) 
	{ 
	double sum = 0; 
	for (int k = 0; k < M; k++) 
	{ 
		if ((m - k) < 0) sum += buffer[k] * H[M + (m - k) - 1]; 
		else sum += buffer[k] * H[m - k]; 
	} 
	functional += (Y[m] - sum) * (Y[m] - sum); 
} 

return (float)functional; 
}