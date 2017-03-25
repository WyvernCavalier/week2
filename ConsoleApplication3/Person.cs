using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Person
    {
        #region attributes, private
        private string _Title, _FamilyName, _OtherNames, _Country, _Language;
        #endregion

        #region properties, public
        public string Title
        {
            set { _Title = value; }
            get { return _Title; }
        }

        public string FamilyName
        {
            set { _FamilyName = value; }
            get { return _FamilyName; }
        }

        public string OtherNames
        {
            set { _OtherNames = value; }
            get { return _OtherNames; }
        }

        public string Country
        {
            set { _Country = value; }
            get { return _Country; }
        }

        public string Language
        {
            set { _Language = value; }
            get { return _Language; }
        }
        #endregion

        #region constructor, public
        #region default constructor
        public Person() 
        {
            _Title = _FamilyName = _OtherNames = _Country = _Language = "";
        }
        #endregion
        #region alternative constructors
        public Person(string title)
        {
            _Title = title;
            _FamilyName = "No Surname";
            _OtherNames = "";
            _Country = "";
            _Language = "";
        }
        public Person(string title, string surname, string firstname)
        {
            _Title = title;
            _FamilyName = surname;
            _OtherNames = firstname;
            _Country = "AUSTRALIA";
            _Language = "English";
        }
        public Person(string title, string surname, string firstname, string country, string language)
        {
            _Title = title;
            _FamilyName = surname;
            _OtherNames = firstname;
            _Country = country;
            _Language = language;
        }
        #endregion
        #region copy constructor
        public Person(Person person)
        {
            _Title = person.Title;
            _FamilyName = person.FamilyName;
            _OtherNames = person.OtherNames;
            _Country = person.Country;
            _Language = person.Language;
        }
        #endregion
        #endregion

        #region get methods
        public string GetTitle() { return _Title; }
        public string GetFamilyName() { return _FamilyName; }
        public string GetOtherNames() { return _OtherNames; }
        public string GetCountry() { return _Country; }
        public string GetLanguage() { return _Language; }

        #endregion

        #region set methods
        public void SetTitle(string title) { _Title = title; }
        public void SetFamilyName(string name) { _FamilyName = name; }
        public void SetOtherNames(string name) { _OtherNames = name; }
        public void SetCountry(string country) { _Country = country; }
        public void SetLanguage(string language) { _Language = language; }
        #endregion

        #region tostring override
        public override string ToString()
        {
            string temp = new string('*', 50);
            temp += string.Format("\n{0,10}{1,6}{2}", "Field", " ", "Value");
            temp += string.Format("\n{0,10}{1,6}{2} {3} {4}", "Name", " ",
            _Title, _OtherNames, _FamilyName);
            temp += string.Format("\n{0,10}{1,6}{2}", "Born In", " ",_Country);
            temp += string.Format("\n{0,10}{1,6}{2}\n", "Speaks", " ",
            _Language);
            return temp + new string('*', 50) + "\n";
        }
            #endregion
        }


}
