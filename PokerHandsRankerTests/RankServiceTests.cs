﻿using NFluent;
using NUnit.Framework;
using PokerHandsRanker.Interfaces;
using System.Collections.Generic;
using PokerHandsRanker;

namespace PokerHandsRankerTests
{
    public class RankServiceTests
    {
        private IRankService _rankService;

        private readonly List<Rank> _allHandsListed = new List<Rank>
        {
            new Rank(10, ""), // "Royal Flush"
            new Rank(9, ""),  // "Straight Flush"
            new Rank(8, ""),  // "Four of a Kind"
            new Rank(7, ""),  // "Full House"
            new Rank(6, ""),  // "Flush"
            new Rank(5, ""),  // "Straight"
            new Rank(4, ""),  // "Three of a Kind"
            new Rank(3, ""),  // "Two Pairs"
            new Rank(2, ""),  // "Pair"
            new Rank(1, ""),  // "High Card"
        };
        
        [SetUp]
        public void SetUp()
        {
            _rankService = new RankService();
        }

        [Test]
        public void Should_Return_Correct_Royal_Flush()
        {
            var hand = new List<string> { "AC", "KC", "QC", "JC", "TC" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[0].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Straight_Flush()
        {
            // TODO
            var hand = new List<string> { "5C", "6C", "7C", "8C", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[1].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Four_Of_A_Kind()
        {
            // TODO
            var hand = new List<string> { "5C", "5S", "5H", "5D", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[2].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Full_House()
        {
            // TODO
            var hand = new List<string> { "5C", "5S", "5H", "9D", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[3].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Flush()
        {
            // TODO
            var hand = new List<string> { "5C", "8C", "3C", "6C", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[4].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Straight()
        {
            // TODO
            var hand = new List<string> { "2C", "3S", "4H", "5D", "6C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[5].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Three_Of_A_Kind()
        {
            // TODO
            var hand = new List<string> { "5C", "5S", "5H", "8D", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[6].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Two_Pairs()
        {
            // TODO
            var hand = new List<string> { "5C", "5S", "6H", "6D", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[7].RankValue);
        }

        [Test]
        public void Should_Return_Correct_Pair()
        {
            // TODO
            var hand = new List<string> { "5C", "5S", "6H", "8D", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[8].RankValue);
        }

        [Test]
        public void Should_Return_Correct_High_Card()
        {
            // TODO
            var hand = new List<string> { "2C", "5S", "7H", "8D", "9C" };
            var rank = _rankService.GetRankFromHand(hand);
            Check.That(rank.RankValue).IsEqualTo(_allHandsListed[9].RankValue);
        }
    }
}
