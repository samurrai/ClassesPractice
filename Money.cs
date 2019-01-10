using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassesPractice
{
    public class Money
    {
        private int _faceValue;
        private int _amount;

        public Money(int faceValue, int amount)
        {
            _faceValue = faceValue;
            _amount = amount;
        }
        
        public void PrintMoney()
        {
            Console.WriteLine("Номинал купюры - " + _faceValue);
            Console.WriteLine("Количество купюр - " + _amount);
        }

        public bool isEnoughMoney(int cost)
        {
            int sumOfMoney = _faceValue * _amount;
            if (sumOfMoney >= cost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AmountOfProduct(int cost)
        {
            int sumOfMoney = _faceValue * _amount;
            return sumOfMoney / cost;
        }

        public int GetFaceValue()
        {
            return _faceValue;
        }
        public int GetAmount()
        {
            return _amount;
        }

        public void SetFaceValue(int faceValue)
        {
            _faceValue = faceValue;
        }
        public void SetAmount(int amount)
        {
            _amount = amount;
        }

        public int GetSumOfMoney()
        {
            return _faceValue * _amount;
        }
    }
}