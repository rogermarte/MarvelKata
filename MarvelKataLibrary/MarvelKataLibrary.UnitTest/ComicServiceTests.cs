﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarvelKataLibrary.Entities;
using System.Collections.Generic;

namespace MarvelKataLibrary.UnitTest
{
    [TestClass]
    public class ComicServiceTests
    {
        [TestMethod]
        public void GetComicTest()
        {
            //ARRANGE
            MarveApiRepository sut = new MarveApiRepository();
            Comic expected = new Comic()
            {
                Title = "Ultimate Spider-Man 200 (2011) #200 (Marquez Variant)",
                ThumbailUrl = "http://i.annihil.us/u/prod/marvel/i/mg/7/00/5339aada49977.jpg",
                Price = 4.99
            };

            //ACT
            Comic actual = sut.GetComic("Ultimate Spider-Man 200");

            //ASSERT

            Assert.AreEqual(expected.Title, actual.Title, "Error Name");
            Assert.AreEqual(expected.ThumbailUrl, actual.ThumbailUrl,  "Error ThumbailUrl");
            Assert.AreEqual(expected.Price, actual.Price, "Error Price");

        }


        [TestMethod]
        public void GetComicsbyCharacterIdTest()
        {
            //ARRANGE
            MarveApiRepository sut = new MarveApiRepository();
            /*Comic expected = new Comic()
            {
                Title = "Ultimate Spider-Man 200 (2011) #200 (Marquez Variant)",
                ThumbailUrl = "http://i.annihil.us/u/prod/marvel/i/mg/7/00/5339aada49977.jpg",
                Price = 4.99
            };*/

            //ACT
            List<Comic> actual = sut.GetComicsNextWeek();
            
            //ASSERT

            /*Assert.AreEqual(expected.Title, actual.Title, "Error Name");
            Assert.AreEqual(expected.ThumbailUrl, actual.ThumbailUrl, "Error ThumbailUrl");
            Assert.AreEqual(expected.Price, actual.Price, "Error Price");*/

        }
    }
}
