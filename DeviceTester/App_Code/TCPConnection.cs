using System;
using System.Collections.Generic;

using System.Text;
using System.Net.Sockets;
using Xunit;

namespace DeviceTester
{
    class TCPConnection
    {


        private TcpClient _tcpClient;
        private NetworkStream _stream;

        public int Delay = 0;

        public bool ConditionalReading = false;
        public byte EndByte = 3;
        public int ReadBufferSize = 100;

        private int _communicationTimeOut = 500;
        public int CommunicationTimeOut
        {
            get { return _communicationTimeOut; }
            set
            {
                _communicationTimeOut = value;
                _tcpClient.ReceiveTimeout = value;
                _tcpClient.SendTimeout = value;
                _stream.ReadTimeout = value;
                _stream.WriteTimeout = value;
            }
        }

        public TCPConnection(string IP, int port)
        {
            try
            {
                _tcpClient = new TcpClient(IP, port);
                _stream = _tcpClient.GetStream();

            }
            catch (Exception )
            {
                
            }
            
            //_tcpClient.ReceiveTimeout = _communicationTimeOut;
            //_tcpClient.SendTimeout = _communicationTimeOut;
            //_stream.ReadTimeout = _communicationTimeOut;
            //_stream.WriteTimeout = _communicationTimeOut;
        }

        [Theory]
        public void TestRequestData()
        {
            byte[] byteArrayToSend = new byte[] { 10, 20, 30 };
            byte[] incomingBytes = RequestData(byteArrayToSend);
            Assert.True(incomingBytes.Length > 0);
        }

        public byte[] RequestData(byte[] byteArrayToSend)
        {
            try
            {
                byte[] incomingByteArray = new byte[ReadBufferSize];

                if (_stream.CanWrite)
                {
                    _stream.Write(byteArrayToSend, 0, byteArrayToSend.Length);
                    //str_gonderme_sonucu = "Mesaj gitti...";
                }
                else _tcpClient.Close();

                bool goOnReading = true;
                if (_stream.CanRead)
                {
                    //while (goOnReading)
                    //{
                    //    _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);
                    //    for (int i = 0; i < 100; i++)
                    //    {
                    //        if (incomingByteArray[i] == 3) goOnReading = false;
                    //    }
                    //}
                    if (ConditionalReading)
                    {
                        while (goOnReading)
                        {
                            _stream.Read(incomingByteArray, 0, ReadBufferSize);
                            for (int i = 0; i < ReadBufferSize; i++)
                            {
                                if (incomingByteArray[i] == this.EndByte) goOnReading = false;
                            }
                        }
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(Delay);
                        _stream.Read(incomingByteArray, 0, ReadBufferSize);
                    }

                    //---------------
                   /* long totalRead = 0;
                    int read  =0;
                    do
                    {
                        read = _stream.Read(incomingByteArray, 0, ReadBufferSize);
                        if (read > 0)
                            //Add to the read buffer
                            totalRead += read;
                        //else
                        //something went wrong
                    } while (totalRead < ReadBufferSize);*/
                    //----------------

                }
                else _tcpClient.Close();

                return incomingByteArray;
            }
            catch (Exception exp)
            {
                //System.Windows.Forms.MessageBox.Show(exp.ToString());
                return null;
            }

            finally
            {
                _tcpClient.Close();
                _stream.Close();
            }

        }

        public byte[] ReadData()
        {
            try
            {
                byte[] incomingByteArray = new byte[_tcpClient.ReceiveBufferSize];

                if (_stream.CanRead)
                {
                    _stream.Read(incomingByteArray, 0, (int)_tcpClient.ReceiveBufferSize);
                }
                else _tcpClient.Close();

                return incomingByteArray;
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.ToString());
                throw;
            }

            //finally
            //{
            //    _tcpClient.Close();
            //    _stream.Close();
            //}

        }

        public void SetTimeOuts(int timeOut)
        {
            _tcpClient.ReceiveTimeout = CommunicationTimeOut;
            _tcpClient.SendTimeout = CommunicationTimeOut;
            _stream.ReadTimeout = CommunicationTimeOut;
            _stream.WriteTimeout = CommunicationTimeOut;
        }

    }
}
