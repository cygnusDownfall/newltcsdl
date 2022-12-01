using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class TKDTO
    {
        private string _matk;
        private string _tentk;
        private string _matkhau;
        private string _quyen;

        public string Matk
        {
            get
            {
                return _matk;
            }

            set
            {
                _matk = value;
            }
        }
        public string Tentk
        {
            get
            {
                return _tentk;
            }

            set
            {
                _tentk = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return _matkhau;
            }

            set
            {
                _matkhau = value;
            }
        }

        public string Quyen
        {
            get
            {
                return _quyen;
            }

            set
            {
                _quyen = value;
            }
        }

        public TKDTO()
        {
            this.Matk = "";
            this.Tentk = "";
            this.Matkhau = "";
            this.Quyen = "";
        }

        public TKDTO(string _matk, string _tentk, string _matkhau, string _quyen)
        {
            this.Matk = _matk;
            this.Tentk = _tentk;
            this.Matkhau = _matkhau;
            this.Quyen = _quyen;
        }
    }
}
