using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class PCDTO
    {
        private string _madschi,_ngaychi,_maphong;
        private int _tongtien;

        public PCDTO()
        {
            this.Madschi = "";
            this.Ngaychi = "";
            this.Maphong = "";
            this.Tongtien = 0;
        }
        public PCDTO(string _madschi, int _tongtien)
        {
            this.Madschi = _madschi;
            this.Tongtien = _tongtien;
            this.Ngaychi = _ngaychi;
            this.Maphong = _maphong;
        }

        public string Madschi
        {
            get
            {
                return _madschi;
            }

            set
            {
                _madschi = value;
            }
        }

        public string Maphong
        {
            get
            {
                return _maphong;
            }

            set
            {
                _maphong = value;
            }
        }

        public string Ngaychi
        {
            get
            {
                return _ngaychi;
            }

            set
            {
                _ngaychi = value;
            }
        }

        public int Tongtien
        {
            get
            {
                return _tongtien;
            }

            set
            {
                _tongtien = value;
            }
        }
    }
}
