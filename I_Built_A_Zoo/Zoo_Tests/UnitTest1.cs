using System;
using Xunit;
using I_Built_A_Zoo.Interfaces;
using I_Built_A_Zoo.Classes;


namespace Zoo_Tests
{
    public class UnitTest1
    { 
        [Fact]
        public void ASnowyOwlisInOwls()
        {
            //Arrange
            Vertibrates newOwl = new Snowy();

            //Assert
            Assert.True(newOwl is Owls);
        }

        [Fact]
        public void ASnowyOwlIsInBirds()
        {
            //Arrange
            Vertibrates newOwl = new Snowy();

            //Assert
            Assert.True(newOwl is Birds);
        }

        [Fact]
        public void ASnowyOwlIsInVertibrates()
        {
            //Arrange
            Vertibrates newOwl = new Snowy();

            //Assert
            Assert.True(newOwl is Vertibrates);
        }

        [Fact]
        public void ASnowyOwlIsNotInBats()
        {
            //Arrange
            Vertibrates newOwl = new Snowy();

            //Assert
            Assert.False(newOwl is Bats);
        }

        [Fact]
        public void ASnowyOwlIsNotInMammals()
        {
            //Arrange
            Vertibrates newOwl = new Snowy();

            //Assert
            Assert.False(newOwl is Mammals);
        }

        [Fact]
        public void AmericanAlligatorImplementsISwim()
        {
            //Arrange
            Vertibrates newAlligator = new American();

            //Assert
            Assert.True(newAlligator is ISwim);
        }

        [Fact]
        public void FruitBatImplementsIFly()
        {
            //Arrange
            Vertibrates newBat = new FruitBat();

            //Assert
            Assert.True(newBat is IFly);
        }

        [Fact]
        public void CommonLoonImplementsIFlyandISwim()
        {
            //Arrange
            Vertibrates newLoon = new Common();

            //Assert
            Assert.True((newLoon is IFly) && (newLoon is ISwim));
        }

    }
}
