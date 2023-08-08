using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong7
{
    [Serializable]
    class Employee
    {
        string ten;
        int tuoi;
        string diachi;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public Employee()
        {

        }
        public Employee(string ten, int tuoi, string diachi)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.diachi = diachi;
        }

    }
}
