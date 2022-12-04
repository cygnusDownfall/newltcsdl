using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DTO
{
    class PCDTO
    {
        private string _mapc, _lydo, _ngaychi, _maphong;
        private int _sotien;

        public PCDTO()
        {
            this.Mapc = "";
            this.Lydo = "";
            this.Ngaychi = "";
            this.Maphong = "";
            this.Sotien = 0;
        }
        public PCDTO(string _mapc, string _lydo, string _ngaychi, string _maphong, int _sotien)
        {
            this.Mapc = _mapc;
            this.Lydo = _lydo;
            this.Ngaychi = _ngaychi;
            this.Maphong = _maphong;
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

        public string Mapc
        {
            get
            {
                return _mapc;
            }

            set
            {
                _mapc = value;
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
    }
}
