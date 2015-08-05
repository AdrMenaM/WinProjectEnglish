/* Adrián Mena Manciati
 * Fecha: 30-07-2015
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;

namespace WinProjectEnglish
{
    class Audio
    {
        private WaveIn ondaEntrada;
        private WaveFileWriter ficheroOndaSalida;

        /// <summary>
        /// Constructor por defecto (frecuencua de muestreo: 44100 canales: 2)
        /// </summary>
        public Audio()
        {
            ondaEntrada = new WaveIn(WaveCallbackInfo.FunctionCallback());
            ondaEntrada.WaveFormat = new WaveFormat(44100, 2);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="frecuenciaMuestreo">Frecuencia de muestreo</param>
        /// <param name="canales">Canales</param>
        public Audio(int frecuenciaMuestreo, int canales)
        {
            ondaEntrada = new WaveIn(WaveCallbackInfo.FunctionCallback());
            ondaEntrada.WaveFormat = new WaveFormat(44100, 2);
        }

        /// <summary>
        /// Empieza la grabación
        /// </summary>
        /// <param name="fichero">Path absoluto del fichero a guardar la grabación</param>
        public void Grabar(string fichero)
        {
            ficheroOndaSalida = new WaveFileWriter(fichero, ondaEntrada.WaveFormat);
            ondaEntrada.DataAvailable += new EventHandler<WaveInEventArgs>(ondaEntrada_DatosDisponibles);
            ondaEntrada.StartRecording();
        }

        /// <summary>
        /// Para la grabación
        /// </summary>
        public void Parar()
        {
            ondaEntrada.StopRecording();
            ondaEntrada.Dispose();
            ondaEntrada = null;
            ficheroOndaSalida.Close();
            ficheroOndaSalida = null;
        }

        /// <summary>
        /// Guarda los datos que va recibiendo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ondaEntrada_DatosDisponibles(object sender, WaveInEventArgs e)
        {
            ficheroOndaSalida.Write(e.Buffer, 0, e.BytesRecorded);
        }

        /// <summary>
        /// Enumera todos los dispositivos (el dispositivo de grabación por defecto es el 0)
        /// </summary>
        /// <returns>Lista de todos los dispositivos</returns>
        public List<WaveInCapabilities> EnumerarDispositivos()
        {
            List<WaveInCapabilities> list = new List<WaveInCapabilities>();
            int dispositivosOndaEntrada = WaveIn.DeviceCount;
            for (int i = 0; i < dispositivosOndaEntrada; i++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(i);
                list.Add(deviceInfo);
                //Console.WriteLine("Dispositivo {0}: {1}, {2} canales", i, deviceInfo.ProductName, deviceInfo.Channels);
            }
            return list;
        }
    }
}
