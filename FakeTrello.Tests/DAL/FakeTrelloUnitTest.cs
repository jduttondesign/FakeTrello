using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeTrello.DAL;
using Moq;
using FakeTrello.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FakeTrello.Tests.DAL
{
    [TestClass]
    public class FakeTrelloRepoTests
    {
        public Mock<FakeTrelloContext> fake_context { get; set; }
        public FakeTrelloRepository repo { get; set; }
        public Mock<DbSet<Board>> mock_board_set { get; set; }
        public IQueryable<List<Board>> query_boards { get; set; }
        public List<Board> fake_board_table { get; set; }

        [TestInitialize]
        public void Setup()
        {
            fake_context = new Mock<FakeTrelloContext>();
            mock_board_set = new Mock<DbSet<Board>>();
            repo = new FakeTrelloRepository(fake_context.Object);
        }

        public void CreateFakeDatabase()
        {
            query_boards = fake_board_table.AsQueryable(); //re-express this list as something that understands queries

            //Hey LINQ, use the Provider from our fake board table/list
            mock_boards_set.As<IQueryable<Board>>().Setup(b => b.Provider).Returns(query_boards.Provider);
            mock_boards_set.As<IQueryable<Board>>().Setup(b => b.Expression).Returns(query_boards.Expression);
            mock_boards_set.As<IQueryable<Board>>().Setup(b => b.ElementType).Returns(query_boards.ElementType);
            mock_boards_set.As<IQueryable<Board>>().Setup(b => b.GetEnumerator()).Returns(() => query_boards.GetEnumerator());

            mock_boards_set.Setup(b => b.Add(It.IsAny<Board>())).Callback((Board board) => fake_board_table.Add(board));
            fake_context.Setup(c => c.Boards).Returns(mock_boards_set.Object);//this returns the fake board table as a list
    }

        [TestMethod]
        public void EnsureICanInjectContextInstance()
        {
            FakeTrelloContext context = new FakeTrelloContext();
            FakeTrelloRepository repo = new FakeTrelloRepository(context);

            Assert.IsNotNull(repo.Context);
        }
        [TestMethod]
        public void EnsureICanAddBoard()
        {
            FakeTrelloRepository repo = new FakeTrelloRepository(fake_context.Object);
            ApplicationUserManager a_user = new ApplicationUser
            {
                Id = "my-user-id",
                UserName = "Sammy",
                Email = "sammy@gmail.com"
            }


            //act
            repo.AddBoard("My Board", a_user);

            //assert
            Assert.AreEqual(repo.Context.Boards.Count(), 1);

        }

        [TestMethod]
        public void EnsureICanReturnBoards()
        {
            //arrange
            fake_board_table.Add(new Board { Name = "My Board" });
            CreateFakeDatabase();
           
            //act
            int expected_board_count = 1;
            int actual_board_count = repo.Context.Boards.Count();

            //assert
            Assert.AreEqual(expected_board_count, actual_board_count);
        }

        [TestMethod]
        public void EnsureICanFindABoard()
        {
            //arrange
            fake_board_table.Add(new Board { BoardId = 1, Name = "My Board" });
            CreateFakeDatabase();

            //act
            string expected_board_name = "My Board";
            Board  actual_board_name = repo.GetBoard(1);
            string actual_board_name = repo.GetBoard(1).Name;

            //assert
            Assert.IsNotNull(actual_board);
            Assert.AreEqual(expected_board_name, actual_board_name);
        }

    }
}