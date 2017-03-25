using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class LibraryBook
    {
        #region attributes, private
        private string _Author, _Title, _CallNum;
        #endregion

        #region properties, public
        public string Author
        {
            set { _Author = value; }
            get { return _Author; }
        }

        public string Title
        {
            set { _Title = value; }
            get { return _Title; }
        }

        public string CallNum
        {
            set { _CallNum = value; }
            get { return _CallNum; }
        }
        #endregion

        #region constructor, public
        #region default constructor
        public LibraryBook()
        {
            _Title = _Author=_CallNum="nil";
        }
        #endregion
        #region alternative constructors
        public LibraryBook(string Title)
        { _Title = Title;
            _Author = _CallNum = "nil";
        }

        public LibraryBook(string Title,string Author)
        { _Title = Title;
            _Author = Author;
            _CallNum = "nil";
        }

        public LibraryBook(string Title, string Author,string CallNum)
        {
            _Title = Title;
            _Author = Author;
            _CallNum = CallNum;
        }
        #region copy constructors
        public LibraryBook(LibraryBook Librarybook)
        {
            _Title = Librarybook.Title;
            _CallNum = Librarybook.CallNum;
            _Author = Librarybook.Author;
                }
        #endregion



        #endregion
        #endregion

        #region getmethods
        public string getTitle()
        { return _Title; }
        public string getAuthor()
        { return _Author; }
        public string getCallNum()
        { return _CallNum; }
        #endregion
        #region set methods
        public void setTitles(string title) { _Title = title; }
        public void setAuthor(string author) { _Author = author; }
        public void setCallNum(string callnum) { _CallNum = callnum; }
        #endregion

        #region tostring override
        public override string ToString()
        {
            string temp = new string('*', 50);
            temp+= string.Format("\n{0,10}{1,6}{2}", "Field", " ", "Value");
            temp += string.Format("\n{0,10}{1,6}{2}", "Title", " ", _Title);
            temp += string.Format("\n{0,10}{1,6}{2}", "Author", " ", _Author);
            temp += string.Format("\n{0,10}{1,6}{2}", "Call Number", " ", _CallNum);
            return temp + new string('*', 50) + "\n";

        }
        #endregion
    }
}
