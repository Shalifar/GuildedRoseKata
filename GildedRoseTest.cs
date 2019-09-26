using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        private IGildedRose _gildedRose;

        [Test]
        public void GenericItem_QualityAboveZero_QualityDegradesBy1()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 3, Quality = 3 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 2, Quality = 2 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void GenericItem_QualitySellInAboveZero_SellInDecrements()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 3, Quality = 3 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 2, Quality = 2 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].SellIn, Item[0].SellIn);
        }

        [Test]
        public void GenericItem_QualityCantDegradeBelowZero()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 3, Quality = 0 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 2, Quality = 0 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void GenericItem_SellInPassed_QualityCantDegradeBelowZero()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 0, Quality = 1 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = -1, Quality = 0 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void GenericItem_SellInPassed_QualityDegradesBy2()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = 0, Quality = 5 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "GenericItem", SellIn = -1, Quality = 3 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void AgedBrie_SellInDecreases()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 8 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].SellIn, Item[0].SellIn);
        }

        [Test]
        public void AgedBrie_SellInNotPassed_QualityRaisesBy1()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 8 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void AgedBrie_SellInPassed_QualityRaisesBy2()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 9 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void AgedBrie_SellInNotPassed_QualityCantBeAbove50()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void AgedBrie_SellInPassed_QualityCantBeAbove50()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Aged Brie", SellIn = -1, Quality = 50 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void Sulfuras_QualityNoChange()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 7 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void Sulfuras_SellInNoChange()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 7 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].SellIn, Item[0].SellIn);
        }

        [Test]
        public void BackstagePasses_SellInDecreases()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 8 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].SellIn, Item[0].SellIn);
        }

        [Test]
        public void BackstagePasses_SellInMoreThan10_QualityIncresesBy1()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 8 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void BackstagePasses_SellInMoreThan5LessThan10_QualityIncresesBy2()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 9 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void BackstagePasses_SellInLessThan6_QualityIncresesBy3()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 7 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 10 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void BackstagePasses_SellInPassed_QualityDropsToZero()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 12 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 0 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }

        [Test]
        public void BackstagePasses_QualityCantBeAbove50()
        {
            IList<Item> Item = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 48 }
            };

            IList<Item> ExpectedItem = new List<Item>
            {
                new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 50 }
            };

            GildedRose app = new GildedRose(Item);
            app.UpdateQuality();
            Assert.AreEqual(ExpectedItem[0].Quality, Item[0].Quality);
        }
    }
}
