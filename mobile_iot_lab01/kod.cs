﻿<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             x: Class = "MyFirstMauiApp.MainPage" >

    < ScrollView >
        < VerticalStackLayout
            Spacing = "25"
            Padding = "30,0"
            VerticalOptions = "Center" >

            < Image
                Source = "dotnet_bot.png"
                SemanticProperties.Description = "Cute dot net bot waving hi to you!"
                HeightRequest = "200"
                HorizontalOptions = "Center" />

            < Label
                Text = "Hello, World!"
                SemanticProperties.HeadingLevel = "Level1"
                FontSize = "32"
                HorizontalOptions = "Center" />

            < Label
                Text = "Welcome to .NET Multi-platform App UI"
                SemanticProperties.HeadingLevel = "Level2"
                SemanticProperties.Description = "Welcome to dot net Multi platform App U I"
                FontSize = "18"
                HorizontalOptions = "Center" />

            < Button
                x: Name = "CounterBtn"
                Text = "Click me"
                SemanticProperties.Hint = "Counts the number of times you click"
                Clicked = "OnCounterClicked"
                HorizontalOptions = "Center" />

        </ VerticalStackLayout >
    </ ScrollView >

</ ContentPage >
