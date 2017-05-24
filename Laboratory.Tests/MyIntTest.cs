using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratory.Tests
{
    [TestClass]
    public class MyIntTest
    {
        [TestMethod]
        public void ToStr_from_90_must_give_90_String()
        {
            //arrange
            int val = 90;
            string expected = "90";

            //act
            MyInt ine = new MyInt();
            string answer = ine.ToStr(val);

            //assert

            Assert.AreEqual(expected, answer);
            
        }
        [TestMethod]
        public void check_max()
        {
            //arrange
            MyInt dde = new MyInt(121);
            MyInt tte = new MyInt(323);
            dde = dde.abs().Max(tte.abs());
            Assert.AreEqual(dde.Value, tte.Value);
        }

        [TestMethod]
        public void check_min()
        {
            //arrange
            MyInt dde = new MyInt(100);
            MyInt tte = new MyInt(20);
            dde = dde.Min(tte);
            Assert.AreEqual(dde, tte);
        }
        [TestMethod]
        public void check_abs()
        {
            //arrange
            MyInt dde = new MyInt(-100);
            MyInt tte = new MyInt(100);
            dde = dde.abs();
            Assert.AreEqual(dde.Value, tte.Value);
        }
        [TestMethod]
        public void check_gcd_100_20_20()
        {
            //arrange
            MyInt dde = new MyInt(100);
            MyInt tte = new MyInt(20);
            dde = dde.Gcd(tte);
            Assert.AreEqual(dde.Value, tte.Value);
        }
        [TestMethod]
        public void check_gcd_1071_462_21()
        {
            //arrange
            MyInt dde = new MyInt(462);
            MyInt tte = new MyInt(1071);
            MyInt ans = new MyInt(21);
            dde = dde.Gcd(tte);
            Assert.AreEqual(dde.Value, ans.Value);
        }

        [TestMethod]
        public void compareTo_test_24_equals_24() {
            MyInt a = new MyInt(24);
            MyInt b = new MyInt(24);
            bool c = true;
            if (a.compareTo(b))
            {
              c = true;
            }
            else {
                 c = false;
            }
            Assert.IsTrue(c);
        }



        [TestMethod]
        public void Add_228_to_322_equals_550()
        {
            //arrange
            MyInt dde = new MyInt(228);
            MyInt tdd = new MyInt(322);
            MyInt answer = new MyInt(550);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);

            //assert лкул

            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void Add_2_to_2_eq_4()
        {
            //arrange
            MyInt dde = new MyInt(2);
            MyInt tdd = new MyInt(2);
            MyInt answer = new MyInt(4);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);

            //assert лкул

            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void Add_5_to_5_eq_10()
        {
            //arrange
            MyInt dde = new MyInt(5);
            MyInt tdd = new MyInt(5);
            MyInt answer = new MyInt(10);
            //act
            MyInt lol = new MyInt();
            lol = dde.Add(tdd);

            //assert лкул

            Assert.AreEqual(lol.Value, answer.Value);
        }

        [TestMethod]
        public void Sub_100_55_equals_45()
        {
            MyInt a = new MyInt(100);
            MyInt b = new MyInt(55);
            MyInt ans = new MyInt(45);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);            
        }
        [TestMethod]
        public void Sub_100_minus55_equals_155()
        {
            MyInt a = new MyInt(100);
            MyInt b = new MyInt(-55);
            MyInt ans = new MyInt(155);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }

        [TestMethod]
        public void Sub_55_100_equals_45()
        {
            MyInt a = new MyInt(55);
            MyInt b = new MyInt(100);
            MyInt ans = new MyInt(-45);

            a = a.Sub(b);

            Assert.AreEqual(a.Value, ans.Value);
        }

        [TestMethod]
        public void Mul_2_2_equal_4()
        {
            MyInt a = new MyInt(2);
            MyInt b = new MyInt(2);
            MyInt answer = new MyInt(4);

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void Mul_m20_m20_equal_400()
        {
            MyInt a = new MyInt(-20);
            MyInt b = new MyInt(-20);
            MyInt answer = new MyInt("400");

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void Mul_2234_min234_equal_4()
        {
            MyInt a = new MyInt(2234);
            MyInt b = new MyInt(-234);
            MyInt answer = new MyInt("-522756");

            a = a.Multiply(b);

            Assert.AreEqual(answer.Value, a.Value);
        }

        [TestMethod]
        public void check_long_123456789()
        {
            MyInt ans = new MyInt("123456789");
            long nans = 123456789;

            Assert.AreEqual(ans.longValue(), nans);
        }
    } 
}
