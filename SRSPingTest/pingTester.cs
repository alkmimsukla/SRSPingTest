using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace SRSPingTest
{
    public class pingTester
    {
        Ping pingSender;

        private HostNameOrAddress srscyh;
        private HostNameOrAddress srsshb_s;
        private HostNameOrAddress srsshb_r;
        private HostNameOrAddress srslnb_s;
        private HostNameOrAddress srslnb_l;
        private HostNameOrAddress srslnb_c;
        private HostNameOrAddress srslnb_r;

        private int timeOut = 500;

        public pingTester()
        {
            //CYLINDER HEAD
            srscyh = new HostNameOrAddress();
            srscyh.PCAddress = "172.18.97.10";
            srscyh.HostName = "SRSCYH";
            srscyh.Moxa = "172.18.97.12";

            //SHORT BLOCK SETUP
            srsshb_s = new HostNameOrAddress();
            srsshb_s.PCAddress = "172.18.97.16";
            srsshb_s.HostName = "SRSSHB-S";
            srsshb_s.Moxa = "172.18.97.18";

            //SHORT BLOCK RELEASE
            srsshb_r = new HostNameOrAddress();
            srsshb_r.PCAddress = "172.18.97.21";
            srsshb_r.HostName = "SRSSHB-R";
            srsshb_r.Moxa = "172.18.97.22";

            //LONG BLOCK SETUP
            srslnb_s = new HostNameOrAddress();
            srslnb_s.PCAddress = "172.18.97.24";
            srslnb_s.HostName = "SRSLNB-S";
            srslnb_s.Moxa = "172.18.97.26";

            //LONG BLOCK LEAK TEST
            srslnb_l = new HostNameOrAddress();
            srslnb_l.PCAddress = "172.18.97.28";
            srslnb_l.HostName = "SRSLNB-L";
            srslnb_l.Moxa = "172.18.97.29";

            //LONG BLOCK COLD TEST
            srslnb_c = new HostNameOrAddress();
            srslnb_c.PCAddress = "172.18.97.31";
            srslnb_c.HostName = "SRSLNB-C";
            srslnb_c.Moxa = "172.18.97.32";

            //LONG BLOCK RELEASE
            srslnb_r = new HostNameOrAddress();
            srslnb_r.PCAddress = "172.18.97.34";
            srslnb_r.HostName = "SRSLNB-R";
            srslnb_r.Moxa = "172.18.97.35";
        }

        #region ARC_TESTE
        ////TESTE ARCADRIANO
        //public bool testaARCADRIANO()
        //{
        //    pingSender = new Ping();

        //    try
        //    {
        //        srslnb_r.PC_ReplyStatus = pingSender.Send("ARCADRIANO", timeOut);

        //        pingSender.Dispose();
        //        if (srslnb_r.PC_ReplyStatus.Status == IPStatus.Success)
        //            return true;
        //        return false;

        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        ////TESTE ARCLAB
        //public bool testaARCLAB()
        //{
        //    pingSender = new Ping();

        //    try
        //    {
        //        srslnb_r.MX_ReplyStatus = pingSender.Send("ARCLABORATORIO", timeOut);

        //        pingSender.Dispose();
        //        if (srslnb_r.MX_ReplyStatus.Status == IPStatus.Success)
        //            return true;
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        #endregion

        public bool testaPCCYH()
        {
            pingSender = new Ping();

            try
            {
                srscyh.PC_ReplyStatus = pingSender.Send(srscyh.PCAddress, timeOut);

                pingSender.Dispose();
                if (srscyh.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXCYH()
        {
            pingSender = new Ping();

            try
            {
                srscyh.MX_ReplyStatus = pingSender.Send(srscyh.Moxa, timeOut);

                pingSender.Dispose();
                if (srscyh.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaPCSHBS()
        {
            pingSender = new Ping();

            try
            {
                srsshb_s.PC_ReplyStatus = pingSender.Send(srsshb_s.PCAddress, timeOut);

                pingSender.Dispose();
                if (srsshb_s.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXSHBS()
        {
            pingSender = new Ping();

            try
            {
                srsshb_s.MX_ReplyStatus = pingSender.Send(srsshb_s.Moxa, timeOut);

                pingSender.Dispose();
                if (srsshb_s.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaPCSHBR()
        {
            pingSender = new Ping();

            try
            {
                srsshb_r.PC_ReplyStatus = pingSender.Send(srsshb_r.PCAddress, timeOut);

                pingSender.Dispose();
                if (srsshb_r.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXSHBR()
        {
            pingSender = new Ping();

            try
            {
                srsshb_r.MX_ReplyStatus = pingSender.Send(srsshb_r.Moxa, timeOut);

                pingSender.Dispose();
                if (srsshb_r.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaPCLNBS()
        {
            pingSender = new Ping();

            try
            {
                srslnb_s.PC_ReplyStatus = pingSender.Send(srslnb_s.PCAddress, timeOut);

                pingSender.Dispose();
                if (srslnb_s.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXLNBS()
        {
            pingSender = new Ping();

            try
            {
                srslnb_s.MX_ReplyStatus = pingSender.Send(srslnb_s.Moxa, timeOut);

                pingSender.Dispose();
                if (srslnb_s.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaPCLNBL()
        {
            pingSender = new Ping();

            try
            {
                srslnb_l.PC_ReplyStatus = pingSender.Send(srslnb_l.PCAddress, timeOut);

                pingSender.Dispose();
                if (srslnb_l.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXLNBL()
        {
            pingSender = new Ping();

            try
            {
                srslnb_l.MX_ReplyStatus = pingSender.Send(srslnb_l.Moxa, timeOut);

                pingSender.Dispose();
                if (srslnb_l.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaPCLNBC()
        {
            pingSender = new Ping();

            try
            {
                srslnb_c.PC_ReplyStatus = pingSender.Send(srslnb_c.PCAddress, timeOut);

                pingSender.Dispose();
                if (srslnb_c.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXLNBC()
        {
            pingSender = new Ping();

            try
            {
                srslnb_c.MX_ReplyStatus = pingSender.Send(srslnb_c.Moxa, timeOut);

                pingSender.Dispose();
                if (srslnb_c.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaPCLNBR()
        {
            pingSender = new Ping();

            try
            {
                srslnb_r.PC_ReplyStatus = pingSender.Send(srslnb_r.PCAddress, timeOut);

                pingSender.Dispose();
                if (srslnb_r.PC_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool testaMXLNBR()
        {
            pingSender = new Ping();

            try
            {
                srslnb_r.MX_ReplyStatus = pingSender.Send(srslnb_r.Moxa, timeOut);

                pingSender.Dispose();
                if (srslnb_r.MX_ReplyStatus.Status == IPStatus.Success)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
