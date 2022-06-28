using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entites;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            starbucksCustomerManager.Save( new Customer() {DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108"} );
        }
    }
}
