using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {

        Repository<Author> repoauthor = new Repository<Author>();

        //For  get all Author list
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }

        //New add author
        public int AddAuthorBL(Author p)
        {
            //Filter of entered value
            if(p.AuthorName=="" || p.AboutShort=="" || p.PhoneNumber=="" || p.AuthorTitle == "")
            {
                return -1;
            }
            

            return repoauthor.Insert(p);
        }

        public Author FindAuthor(int id)
        {


            return repoauthor.Find(x => x.AuthorID == id);
        }

        //For Update Blog
        public int EditAuthor(Author p)
        {
            Author author = repoauthor.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            author.AuthorImage = p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AboutShort = p.AboutShort;
            author.Mail = p.Mail;
            author.Password = p.Password;
            author.PhoneNumber = p.PhoneNumber;


            return repoauthor.Update(author);

        }




    }
}
