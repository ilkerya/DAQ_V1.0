﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace VOI_DAQ 
{
    class SP1
    {

       public  static String PortConnectName;
        public static uint ComTimeout;  // SP1.ComTimeout
        public static uint ErrorCount;
        //   uint ReadSequence;
        public static uint ReadSequence;
        public static UInt16 Preamble;
  
        /*
        public static uint Data1;
        public static uint Data2;
        public static uint Data3;
        public static uint Data4;
        public static uint Data5;
        */
        public static UInt16 CRC_Received;
        public static UInt16 Preamble_Trial;
        /*
        public static uint RecCommand;
        public static uint RecAdress;
        public static uint RecAdrLength;
        */
        public static Byte[] ReceiveBuf = new byte[256]; // preamble+length+crc + 4*4 byte data  4 byte + 4 byte + 4 byte + 16 byte
        public static byte[] SendBuf = new byte[256]; // preamble+length+crc + 4*4 byte data  4 byte + 4 byte + 4 byte + 16 byte

   

        public static byte[] Buffer = new byte[256];
/*
        public static UInt16 Send_TotLength;
        public static uint SendCommand;
        public static uint SendAdress;
        public static uint Send_AdrLength;
        public static uint SendData1 = 234;
        public static uint SendData2 = 567;
        public static uint SendData3 = 34567;
        public static uint SendData4 = 11134;
        public static uint SendData5 = 11134;
        public static uint SendCRC;
        */
        public static UInt16 CRC_Calc;
        public static UInt16 CRC_Error;
        public static UInt32 CRC_Success;

        //    static byte[] SP1_ReceiveBuf = new byte[256]; // preamble+length+crc + 4*4 byte data  4 byte + 4 byte + 4 byte + 16 byte
        //    static byte[] SP1_SendBuf = new byte[256]; // preamble+length+crc + 4*4 byte data  4 byte + 4 byte + 4 byte + 16 byte

        //     static byte[] SP1_Buffer = new byte[256];
        
        //       UInt16 PREAMBLE_BYTES + DATA_BYTES
        // constant variables
        public static readonly UInt16 PREAMBLE_BYTES = 2; // preamble+length 4 byte + 2 byte
        public static readonly UInt16 DATALENGTH_BYTES = 2;
        public static readonly UInt16 CRC_BYTES = 2;

        public static readonly UInt16 DEFAULT_PREAMBLE = 0XAAAA; // preamble+length 4 byte + 4 byte
        public static readonly UInt16 DEFAULT_CRC_INIT = 0XAAAA; // preamble+length 4 byte + 4 byte

        public static readonly UInt16 DEFAULT_LENGTH = 20; // islemci tarafindaki ayni def ile degerde olmali

        public static readonly UInt16 SHIFT24 = 24;
        public static readonly UInt16 SHIFT16 = 16;
       public static readonly UInt16 SHIFT8 = 8;

        public static UInt16 Length = DEFAULT_LENGTH;

    }



}



