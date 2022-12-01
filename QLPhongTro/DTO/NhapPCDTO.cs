using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class NhapPCDTO
    {
        private int _stt, _sotien;
        private string _madschi, _ngaychi, _lydo, _maphong;

        public NhapPCDTO()
        {
            this.Madschi = "";
            this.Ngaychi = "";
            this.Lydo = "";
            this.Maphong = "";
            this.Stt = 0;
            this.Sotien = 0;
        }
        public NhapPCDTO(string _madschi, string _ngaychi, string _lydo, string _maphong, int _stt, int _sotien)
        {
            this.Madschi = _madschi;
            this.Ngaychi = _ngaychi;
            this.Lydo = _lydo;
            this.Maphong = _maphong;
            this.Stt = _stt;
            this.Sotien = _sotien;
        }

        public string Lydo
        {
            get
            {
                return _lydo;
            }

            set
            {
                _lydo = value;
            }
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

        public int Sotien
        {
            get
            {
                return _sotien;
            }

            set
            {
                _sotien = value;
            }
        }

        public int Stt
        {
            get
            {
                return _stt;
            }

            set
            {
                _stt = value;
            }
        }
    }
}
