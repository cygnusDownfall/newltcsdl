using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class PTDTO
    {
        private string _maphong, _tenphong, _makv, _trangthai, _manhomtb;
        private int _slkt, _gia;

        public PTDTO()
        {
            this.Maphong = "";
            this.Tenphong = "";
            this.Makv = "";
            this.Trangthai = "";
            this.Manhomtb = "";
            this.Slkt = 0;
            this.Gia = 0;
        }
        public PTDTO(string _maphong, string _tenphong, string _makv, string _trangthai, string _manhomtb, int _slkt, int _gia)
        {
            this.Maphong = _maphong;
            this.Tenphong = _tenphong;
            this.Makv = _makv;
            this.Trangthai = _trangthai;
            this.Manhomtb = _manhomtb;
            this.Slkt = _slkt;
            this.Gia = _gia;
        }

        public int Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }

        public string Makv
        {
            get
            {
                return _makv;
            }

            set
            {
                _makv = value;
            }
        }

        public string Manhomtb
        {
            get
            {
                return _manhomtb;
            }

            set
            {
                _manhomtb = value;
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

        public int Slkt
        {
            get
            {
                return _slkt;
            }

            set
            {
                _slkt = value;
            }
        }

        public string Tenphong
        {
            get
            {
                return _tenphong;
            }

            set
            {
                _tenphong = value;
            }
        }

        public string Trangthai
        {
            get
            {
                return _trangthai;
            }

            set
            {
                _trangthai = value;
            }
        }
    }
}
