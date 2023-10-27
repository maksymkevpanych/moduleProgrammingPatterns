using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// в цьому завданні використаний шаблон Прототип, тому що в завданні потрібно копіювати,а шаблон Прототип ідеально підходить для цього.
public class Payment
{
    public int Id { get; set; }
    public string Purpose { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
    public Recipient Recipient { get; set; }

    public Payment CopyPayment(Payment originalPayment)
    {
        return new Payment
        {
            Id = originalPayment.Id,
            Purpose = originalPayment.Purpose,
            Date = DateTime.Today,
            Amount = originalPayment.Amount,
            IsPaid = originalPayment.IsPaid,
            Recipient = new Recipient
            {
                Name = originalPayment.Recipient.Name,
                Code = originalPayment.Recipient.Code
            }
        };
    }
}

public class Recipient
{
    public string Name { get; set; }
    public string Code { get; set; }
}
namespace modulProgrammingPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Recipient recipient = new Recipient
            {
                Name = "Отримувач 1",
                Code = "1234567890"
            };

           
            Payment payment = new Payment
            {
                Id = 1,
                Purpose = "Оплата послуги",
                Date = new DateTime(2023, 02, 15),
                Amount = 1500,
                IsPaid = false,
                Recipient = recipient
            };

            
            Payment copiedPayment = payment.CopyPayment(payment);

            
            Console.WriteLine(copiedPayment.Id); 
            Console.WriteLine(copiedPayment.Purpose);
            Console.WriteLine(copiedPayment.Date); 
            Console.WriteLine(copiedPayment.Amount); 
            Console.WriteLine(copiedPayment.IsPaid); 
            Console.WriteLine(copiedPayment.Recipient.Name); 
            Console.WriteLine(copiedPayment.Recipient.Code); 
            Console.ReadLine();
        }
    }
}
