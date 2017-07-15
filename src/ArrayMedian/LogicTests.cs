using NUnit.Framework;

namespace ArrayMedian
{
    class LogicTests
    {

        private Logic _logic;

        [SetUp]
        public void SetUp()
        {
            _logic = new Logic();
        }

        [Test]
        public void Should_Sort_Array_Ascending()
        {
            //given
            int[] unsortedArray = new int[] { 5, 6, 2, 7, 1 };

            //When
            var result = _logic.SortArray(unsortedArray);

            //Then
            Assert.That(result[0], Is.EqualTo(1));
            Assert.That(result[4], Is.EqualTo(7));
        }

        [Test]
        public void Should_Return_Array_Length()
        {
            //given
            int[] array = new int[] { 5, 6, 2, 7, 1 };

            //When
            var result = _logic.ReturnLength(array);

            //Then
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Should_Return_Array_Median_For_Odd_Number_Of_Elements()
        {
            //given
            int[] array = new int[] {1,2,3,4,5};

            //When
            var result = _logic.FindMedian(array);

            //Then
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Should_Return_Array_Median_For_Even_Number_Of_Elements()
        {
            //given
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            //When
            double result = _logic.FindMedian(array);

            //Then
            Assert.That(result, Is.EqualTo(3.5));
        }

        [Test]
        public void Should_Return_Array_Median_For_Unsorted_Array()
        {
            //given
            int[] array = new int[] { 5,3,6,2,4,1 };

            //When
            double result = _logic.FindMedian(array);

            //Then
            Assert.That(result, Is.EqualTo(3.5));
        }


    }
}
