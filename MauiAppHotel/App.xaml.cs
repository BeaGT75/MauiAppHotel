﻿using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
                {
                    Descricao = "Suíte Super Luxo",
                    ValorDiariaAdulto = 110.0,
                    ValorDiariaCrianca = 55.0
                },
            new Quarto()
                {
                    Descricao = "Suíte Luxo",
                    ValorDiariaAdulto = 80.0,
                    ValorDiariaCrianca = 40.0
                },
            new Quarto()
                {
                    Descricao = "Suíte Single",
                    ValorDiariaAdulto = 50,
                    ValorDiariaCrianca = 25.0
                },

            new Quarto
                {
                    Descricao = "Suíte da Crise",
                    ValorDiariaAdulto = 25,
                    ValorDiariaCrianca = 12.5
                }
        };//Fecha List Quarto
        



        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        { 
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }//Fecha Método CreateWindow

    }//Fecha Classe App
} // Fecha namespace
