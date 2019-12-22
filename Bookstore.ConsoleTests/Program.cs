using System;
using Bookstore.ConsoleTests.Application.Mapper;

namespace Bookstore.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            new BookDtoMapperTests()
                .Map_Always_AllPropertiesMapped();
        }
    }
}
