using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class KTDTO
    {
        private string _makt, _tenkt, _diachi, _maphong, _cmnd, _sdt;

        public string Makt
        {
            get
            {
                return _makt;
            }

            set
            {
                _makt = value;
            }
        }

        public string Tenkt
        {
            get
            {
                return _tenkt;
            }

            set
            {
                _tenkt = value;
            }
        }

        public string Diachi
        {
            get
            {
                return _diachi;
            }

            set
            {
                _diachi = value;
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

        public string Cmnd
        {
            get
            {
                return _cmnd;
            }

            set
            {
                _cmnd = value;
            }
        }

        public string Sdt
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
            }
        }

        public KTDTO()
        {
            this.Makt = "";
            this.Tenkt = "";
            this.Diachi = "";
            this.Maphong = "";
            this.Cmnd = "";
            this.Sdt = "";
        }
        public KTDTO(string _makt, string _tenkt, string _diachi, string _maphong, string _cmnd, string _sdt)
        {
            this.Makt = _makt;
            this.Tenkt = _tenkt;
            this.Diachi = _diachi;
            this.Maphong = _maphong;
            this.Cmnd = _cmnd;
            this.Sdt = _sdt;
        }
    }
}
