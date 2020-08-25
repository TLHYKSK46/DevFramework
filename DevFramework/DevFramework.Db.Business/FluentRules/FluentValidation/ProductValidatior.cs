using DevFramework.Db.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Db.Business.FluentRules.FluentValidation
{
   public class ProductValidatior:AbstractValidator<Product>
    {
        public ProductValidatior() {
            RuleFor(p => p.CategoryID).NotEmpty().WithMessage("Kategori Boş Geçemez");//bu şekilde kendi mesajlarımızı verebiliyoruz..
            RuleFor(p => p.ProductName).NotEmpty();//boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0);//sıfırdan büyük olmalı
            RuleFor(p => p.QuantityPerUnit).NotEmpty();//boş olamaz
            RuleFor(p => p.ProductName).Length(2,20);//min :2 max:20 olabilir
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p=>p.CategoryID==1);//kategori ıd 1 ise minumum degeri 20 olsun
            /*RuleFor(p => p.ProductName).Must(Kural);*///Kendi Kurallarımızıda oluşturur
        }

        private bool Kural(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
