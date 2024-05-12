using System;
using System.Collections.Generic;

namespace SystemParking 
{
    public class ParkingModel 
    {
        private List<string> parking = new List<string>();
        private double valueInitial;
        private double valueHour;
        public ParkingModel(double valueInitial, double valueHour)
        {
            this.valueInitial = valueInitial;
            this.valueHour = valueHour;
        }
        public void setValueInitial(double valueInitial) 
        {
            this.valueInitial = valueInitial;
        }
        public double getValueInitial() 
        {
            return valueInitial;
        }
        public void setValueHour(double valueHour) 
        {
            this.valueHour = valueHour;
        }
        public double getValueHour() 
        {
            return valueHour;
        }
        public void addCar(string plate) 
        {
            parking.Add(plate);
        }
        public void removeCar(string place) {
            int quantityHours;
            foreach(string car in parking) 
            {
                if(car==place) 
                {
                    Console.WriteLine("Quantas horas o veículo passou no estacionamento?");
                    quantityHours = int.Parse(Console.ReadLine());
                    calculateValue(quantityHours);
                    parking.Remove(place);
                    break;
                } 
                else 
                { 
                    Console.WriteLine("Não existe registro dessa placa em nosso sistema");
                }
            }
        }
        public void calculateValue(int quantityHours) {
            Console.Write("O veículo precisa pagar R$ " + (getValueHour()*quantityHours) + getValueInitial());
        }
        public void printCar() 
        {
            foreach(string car in parking) 
            {
                Console.WriteLine(car);
            }
        }
    }
}