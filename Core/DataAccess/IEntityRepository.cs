using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint kıstlama IEntityRepository içine T olarak sadece concrete dosyası içindeki classlar(referans tipler) gelmesi için where T:class
    //ve Ientity veya Ientityden implemente eden bir nesne olabilir
    //new lenebilir olmalıdır yanı abstract degil constractor olmalı  yani new ekleyince <IEntity>  yazıldığında kabul etmez
    public interface IEntityRepository<T> where T : class,IEntity, new() //I entity olmasaydı concrete dışındaki classlarıda alırdı
    {
        //Generic Repository
        //filtre =null filtre vermeyede bilirsin
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //tek bir verinin detayları için
        T Get(Expression <Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
