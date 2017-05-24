using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class MyInt
    {
        public string Value = "";

        //Конструкторы
        public MyInt()
        {
            Value = "";
        }
        public MyInt(int lolqop) {
            Value = ToStr(lolqop);

        }
        public MyInt(string lolqop) {
            Value = lolqop;
        }
        public MyInt(int[] pop) {
            for (int i = 0; i < pop.Length; i++) {
                if (i == 0)
                {
                    if (pop[i] == 1) Value = "-";
                    else if (pop[i] == 0) Value = "";
                }
                else
                {
                    Value = Value + pop[i];
                }
            }
        }


        //Арифметические методы
        public MyInt Add(MyInt other)
        {
            
            string answer ="";
            string A = this.Value;
            string B = other.Value;
            int Az = 0;
            int Bz = 0;

            if (A[0] == '-')
            {
                Az = 1;
                A = A.Substring(1);
            }
            if (B[0] == '-')
            {
                Bz = 1;
                B = B.Substring(1);
            }
            char[] arr = A.ToCharArray();
            Array.Reverse(arr);
            A = new string(arr);
            arr = B.ToCharArray();
            Array.Reverse(arr);
            B = new string(arr);

            int r = A.Length - B.Length;
            if (r > 0)
            {
                for (int i = 0; i < r; i++)
                {
                    B = B + "0";
                }
            }
            else if (r < 0)
            {
                r = -r;
                for (int i = 0; i < r; i++)
                {
                    A = A + "0";
                }
            }


            if (Az != Bz)
            {
                if (this.compareTo(other)) return new MyInt("0");
                else
                {
                    if (this.abs().Value == this.abs().Max(other.abs()).Value)
                    {
                        answer = subs(A, B);
                        bool isOver = false;
                        int cc = 0;
                        for (int i = 0; i < answer.Length; i++)
                        {
                            
                            if (answer[i] != '0') isOver = true;
                            else cc++;

                            if (isOver)
                            {
                                answer = answer.Substring(cc);
                                break;
                            }
                        }
                        if (Az == 1) answer = "-" + answer;                      

                    }
                    else if (other.abs().Value == (this.abs().Max(other.abs())).Value)
                    {
                        answer = subs(B, A);
                        bool isOver = false;
                        int cc = 0;
                        for (int i = 0; i < answer.Length; i++)
                        {
                            
                            if (answer[i] != '0') isOver = true;
                            else cc++;

                            if (isOver)
                            {
                                answer = answer.Substring(cc);
                                break;
                            }
                        }
                        if (Bz == 1) answer = "-" + answer;
                    }
                }
            }
            else
            {
                answer = adds(A, B);
                if (Az == 1) answer = "-" + answer;
            }

            

            return new MyInt(answer);
        }
        public MyInt abs()
        {
            if (Value[0] == '-') Value = Value.Substring(1);
            return new MyInt(Value);
        }
        public MyInt Sub(MyInt other)
        {
            MyInt answer;

            if (other.Value[0] != '-') other = new MyInt("-" + other.Value);
            else other = other.abs();

            answer = this.Add(other);
            return answer;
        }
        public MyInt Multiply(MyInt other)
        {
            MyInt ans = new MyInt("0");
            string A = this.Value;
            string B = other.Value;
            int Az = 0;
            int Bz = 0;
            if (A[0] == '-')
            {
                Az = 1;
              //A = A.Substring(1);
            }
            if (B[0] == '-')
            {
                Bz = 1;
                B = B.Substring(1);
            }

            char[] arr = B.ToCharArray();
            Array.Reverse(arr);
            B = new string(arr);

            int multer = 1;
            

            for (int i = 0; i < B.Length; i++)
            {
                int n = int.Parse(B[i].ToString());
                n = n * (int)Math.Pow(10, i);
                for (int j = 0; j < n; j++)
                {
                    ans = ans.Add(this.abs());
                    string val = ans.Value;
                }
                multer++;
            }
            if (Az != Bz)
            {
                ans = new MyInt("-" + ans.Value);
            }

            return ans;

        }

        
        //Методы сравнения

        public MyInt Max(MyInt other)
        {
            string A = Value;
            string B = other.Value;
            int Az = 0;
            int Bz = 0;

            if (A[0] == '-')
            {
                Az = 1;
                A = A.Substring(1);
            }
            if (B[0] == '-')
            {
                Bz = 1;
                B = B.Substring(1);
            }

            if (Az == 0 && Bz == 1) return this;
            else if (Az == 1 && Bz == 0) return other;
            else
            {
                if (A.Length > B.Length) return this;
                else if (B.Length > A.Length) return other;
                else
                {
                    bool isAmax = true;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (int.Parse(A[i].ToString()) > int.Parse(B[i].ToString())) break;
                        else if (int.Parse(A[i].ToString()) < int.Parse(B[i].ToString()))
                        {
                            isAmax = false;
                            break;
                        }                        
                    }

                    if (isAmax) return this;
                    else return other;
                }
            }

        }
        public bool compareTo(MyInt other)
        {
            if (Value == other.Value) return true;
            else return false;
        }
        public MyInt Min(MyInt other)
        {
            MyInt lel = this.Max(other);

            if (lel.Equals(this)) return other;
            else return this;
        }


        //Нахождение НОД

        public MyInt Gcd(MyInt other)
        {
            string what = "";
            MyInt answer = new MyInt("0");
            this.abs();
            other = other.abs();
            if (this.abs().Value == this.abs().Max(other.abs()).Value)
            {
                answer = this;
                while (answer.Value != "0")
                {
                    answer = answer.Sub(other.abs());
                    what = answer.Value;
                    if (answer.abs().Value == answer.abs().Min(other.abs()).Value)
                    {
                        MyInt raz = other;
                        other = answer;
                        answer = raz;
                    }
                    if (other.Value == answer.Value) break;
                }
                return answer;

            }
            else if (other.abs().Value == (this.abs().Max(other.abs())).Value)
            {
                MyInt subber = this;
                answer = other;
                while (answer.abs().Value != "0")
                {
                    answer = answer.Sub(subber.abs());
                    what = answer.Value;
                    if (answer.abs().Value == answer.abs().Min(subber.abs()).Value)
                    {
                        MyInt raz = subber;
                        subber = answer;
                        answer = raz;
                    }
                    if (subber.Value == answer.Value) break;
                }
                return answer;

            }
            else return this;
        }

        //Служебные всякие методы
        public long longValue()
        { 
            long answer = 0;
            int range = 19;
            int Az = 0;
            string loli = "";
            if (Value[0] == '-')
            {
                loli = Value.Substring(1);
                Az = 1;
            }
            else loli = Value;
            int pow = loli.Length - 1;
            int j = 0;
            for (int i = pow; i > -1 && range > 0; i--)
            {
                int a = int.Parse(loli[j].ToString());
                answer += a * (long)Math.Pow(10, i);
                j++;
                range--;
            }

            if (Az == 1) answer = -answer;

            return answer;
        }
        public string ToStr(int val)
        {
            bool isMin = false;
            if (val < 0)
            {
                isMin = true;
                val = -val;
            }


            string result = "";

            long div = 10;
            long ost = 0;
            long dep = val;

            for (int i = 0; dep > 0; i++)
            {
                ost = dep % div;
                result = ost+result;
                dep = dep / div;       
                
            }

            if (isMin) result = "-"+result;
            return result;
        }
        private string subs(string str1, string str2)
        {
            string result = "";
            int mind = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < str1.Length; i++)
            {

                a = int.Parse(str1[i].ToString());
                b = int.Parse(str2[i].ToString());

                
                if (a < mind)
                {
                    a = a + 10 - mind;
                    mind = 1;
                }
                else
                {
                    a = a - mind;
                    mind = 0;
                }                

                if (a < b)
                {
                    c = a + 10 - b;
                    mind = 1;
                }
                else c = a - b;

                result = c + result;
            }
            return result;
        }
        private string adds(string str1, string str2)
        {
            string result = "";

            int mind = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < str1.Length; i++)
            {

                a = int.Parse(str1[i].ToString());
                b = int.Parse(str2[i].ToString());

                a = a + mind;
                if (a < 10)
                {
                    mind = 0;
                }
                else
                {
                    a = a % 10;
                    mind = 1;
                }

                c = a + b;
                if (c > 9)
                {
                    c = c % 10;
                    mind = 1;
                }

                result = c + result;
            }
            if (mind == 1)
            {
                result = "1" + result;
            }

            return result;
        }
    }
}
