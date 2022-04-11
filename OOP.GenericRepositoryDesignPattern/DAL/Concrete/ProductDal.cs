using OOP.GenericRepositoryDesignPattern.DAL.Abstract;
using OOP.GenericRepositoryDesignPattern.Entities.Concrete;
using System.Collections.Generic;

namespace OOP.GenericRepositoryDesignPattern.DAL.Concrete
{
    public class ProductDal :BaseRepository<Product>, IProductDal
    {
    }
}
