using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        #region property của employee
        private int _id;
        private string _id_card;
        private string _name;
        private string _email;
        private string _phone;
        #endregion
        #region constructor
        public Employee() 
        { //có thể để trống, chỉ thêm vào nếu xác định được giá trị khởi tạo
            this._id = 1;
            _id_card = "096042065340";
            this._name = "Ibama";
        }

        public Employee(int _id, string _id_card, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._id_card = _id_card;
            this._name = _name;
            Email = _email;
            Phone = _phone;
        }
        #endregion
        #region nhóm các property của employee
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string IdCard
        {
            get { return _id_card; }
            set { _id_card = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        #region nhóm các phương thức của employee
        public void PrintInfo()
        {
            string msg = $"ID: {Id}\tID Card: {IdCard}\tName: {Name}\tEmail: {Email}\tPhone: {Phone}";
            Console.WriteLine(msg);

        }
        public override string ToString()
        {
            string msg = $"ID: {Id}\tID Card: {IdCard}\tName: {Name}\tEmail: {Email}\tPhone: {Phone}";
            return msg;
        }
        #endregion
    }
}
