using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0318
{

    public class BankAccount
    {
        private double interest;   //이자율
        private string accNum;           //계좌번호
        private string name;             //예금주명
        private int balance;         //잔액        

        private int user;


        public BankAccount()
        {
            interest = 0.2;
            accNum = "";
            name = "";
            balance = 0;
            user = 0;

        }

        //BankAccount[] bankAccounts = new BankAccount[10];


        public void NewaccNum()
        {
            Random random = new Random();
            for (; ; )
            {
                Console.Write("이름을 입력하세요: ");
                string inName = Console.ReadLine();

                if (inName == "")
                    Console.WriteLine("다시 입력해주세요");
                else
                {

                    //bankAccounts[user].name = inName;
                    name = inName;
                    //bankAccounts[user].accNum = Convert.ToString(random.Next(10000, 11111));
                    accNum = Convert.ToString(random.Next(10000, 11111));
                    Console.WriteLine("생성되었습니다.");
                    //user++;
                    break;
                }
            }

        }
        //출금
        public void OutputMoney(int amount)
        {
            //bankAccounts[user].balance = bankAccounts[user].balance - amount;
            if (this.balance > amount)
                this.balance = this.balance - amount;
            else
                Console.WriteLine("잔액이 부족합니다.");
        }

        //예금
        public void InputMoney(int amount)
        {
            //bankAccounts[user].balance = bankAccounts[user].balance + amount + (int)(amount * interest);
            this.balance = this.balance + amount + (int)(amount * interest);
        }
        // 잔액조회
        public int ViewMoney()
        {
            //return bankAccounts[user].balance;
            return this.balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount Ba1 = new BankAccount();
            int Money = 0;
            for (; ; )
            {
                Console.WriteLine(" 1. 계좌생성  2. 잔액조회  3. 입금  4. 출금  5. 종료");
                int Input = Convert.ToInt32(Console.ReadLine());

                switch (Input)
                {
                    case 1:

                        Ba1.NewaccNum();

                        break;

                    case 2:
                        Console.WriteLine(Ba1.ViewMoney());
                        break;

                    case 3:
                        Console.Write("입금 금액을 입력하세요. :");
                        Money = Convert.ToInt32(Console.ReadLine());
                        Ba1.InputMoney(Money);
                        break;

                    case 4:
                        Console.Write("출금 금액을 입력하세요. :");
                        Money = Convert.ToInt32(Console.ReadLine());
                        Ba1.OutputMoney(Money);
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("1~5사이의 숫자를 입력해주세요.");
                        break;
                }
                if (Input == 5)
                    break;
            }
        }
    }
}
