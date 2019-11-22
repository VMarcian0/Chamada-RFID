using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace ConectTest
{
    public class Persona
    {
        private String curso;

        public Persona(String n, String cc, Boolean p, String id)
        {
            Nome = n;
            curso = cc;
            Professor = p;
            RFID = id;
        }
        public string Nome { get; set; }
        public string Curso
        {
            get { return curso; }
            set { curso = value; } 
        }
        public Boolean Professor { get; set; }
        public string RFID { get; set; }
    }
    public class Aluno
    {   public Aluno(String nome, int ra, String rfid, int cod_cur)
        {
            Nome = nome;
            RA = ra;
            RFID = rfid;
            cod_curso = cod_cur;
        }
        public string Nome { get; set;}
        public int RA { get; set; }
        public string RFID { get; set; }
        public int cod_curso { get; set; }
    }
    public class Professor
    {
        public Professor(String nome, int id, String rfid)
        {
            Nome = nome;
            Id = id;
            RFID = rfid;
            
        }
        public string Nome { get; set; }
        public int Id { get; set; }
        public string RFID { get; set; }
        
    }
    public class Arduino
    {
        public static SerialPort arduino;
        //Thread readThread = new Thread(Read);
        public Arduino(string nome, int bauldRate)
        {
            arduino = new SerialPort(nome, bauldRate);
            arduino.ReadTimeout = 5000;//cada leitura tem uma janela de 5 segundos para acontecer
        }
        public void Abrir()
        {
            try
            {
                arduino.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e);
            }
        }
        public void Fechar()
        {
            try
            {
                arduino.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Erro: " + e);
            }
        }
        public string Ler()
        {
            Abrir();
            string leitura = "";
            try
            {
              arduino.WriteLine("Lendo Cartao");
              arduino.DiscardInBuffer();
              leitura = arduino.ReadLine().Replace("\r", "").ToString().ToUpper();
              Fechar();
              return leitura;
            }
            catch (TimeoutException e)
            {
              arduino.WriteLine("Tempo excedido");
              Fechar();
            }
            return "Erro na leitura";
        }
        public void escrever(String txt)
        {
            Abrir();
            arduino.WriteLine(txt);
            Fechar();
        }
    }
}
