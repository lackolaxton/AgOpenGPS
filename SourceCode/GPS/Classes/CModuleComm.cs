﻿using System.Text;

namespace AgOpenGPS
{
    public class CModuleComm
    {
        //copy of the mainform address
        private FormGPS mf;

        //properties for relay control of sections and input lines, 8 bit bytes
        public byte[] relaySectionControl = new byte[1];
        public byte[] digitalInputLines = new byte[1];

        //distance in cm from guidance line
        public int guidanceLineDistance;

        //set and actual headings
        public double autosteerSetpointHeading, autosteerActualHeading;

        //property to receive NMEA sentence from GPS
        //public StringBuilder nmeaCommandRecv;

        //public StringBuilder commandAutosteerSend;
        //public StringBuilder commandAutosteerRecv;

        //public StringBuilder commandRelaySend;
        //public StringBuilder commandRelayRecv;

        //send and recv strings from all possible input outputs
        public StringBuilder udpSentenceSend;
        public StringBuilder udpSentencRecv;

        public StringBuilder serialGPSRecv;

        public StringBuilder serialRelaySend;
        public StringBuilder serialRelayRecv;

        public StringBuilder serialAutosteerSend;
        public StringBuilder serialAutosteerRecv;


       //constructor
        public CModuleComm(FormGPS f)
        {            
            this.mf = f;

            //control all relays based on byte value, 1 means on, 0 means off
            relaySectionControl[0] = 0;

            //set the byte value for the digital input lines to 0 means low, 1 means high, active low
            digitalInputLines[0] = 0;

            //the relay for sectionControl
            serialRelayRecv = new StringBuilder();

            //distance from guidance line in cm
            guidanceLineDistance = 9999;

            //what is the actual heading of the Vehicle
            autosteerActualHeading = 0;

            //what is AB line heading or contour segment heading at current fix
            autosteerSetpointHeading = 0;
        }



    }
}
