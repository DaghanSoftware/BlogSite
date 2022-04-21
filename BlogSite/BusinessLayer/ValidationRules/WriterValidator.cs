using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(60).WithMessage("Lütfen en az 60 karakter girişi yapın");
            

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi kısmı boş geçilemez");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şİfre  kısmı boş geçilemez")
                .Matches("[A-Z]").WithMessage("En az 1 büyük harf içermelidir.")
                .Matches("[a-z]").WithMessage("En az 1 küçük harf içermelidir.")
                .Matches("[0-9]").WithMessage("En az 1 rakam içermelidir.")
                .Matches("[^a-zA-Z0-9]").WithMessage("En az 1 simge içermelidir.");

            //RuleFor(x => x.WriterPassword).Must(IsPasswordValid).WithMessage("Parola en az 6 karakter olmalıdır.En az bir harf ve bir sayı içermelidir");
            //RuleFor(x => x.WriterPasswordConfirm).Equal(x => x.WriterPassword).WithMessage("Passwords do not match");


        }
        private bool IsPasswordValid(string arg)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$");
                return regex.IsMatch(arg);
            }
            catch
            {
                return false;
            }
        }
    }
}
