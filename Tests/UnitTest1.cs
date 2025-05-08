
using Solution;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Methods_Function_ReturnsMinus10InNormalCase()
        {
            int[] temp = [4, 0, 3, 19, 492, -10, 1];
            var result = Methods.Function(temp);
            Assert.Equal(-10, result);
        }
        [Fact]
        public void Methods_Function_ReturnThrowStringInNullCase()
        {
            int[] temp = null;
            var result = Methods.Function(temp);
            Assert.True(result is string);
        }
        [Fact]
        public void Methods_Function_ReturnsThrowStringInEmptyCase()
        {
            int[] temp = [];
            var result = Methods.Function(temp);
            Assert.True(result is string);
        }
        [Fact]
        public void Methods_Function_ReturnsThrowStringIfCountElementsNon2()
        {
            int[] temp = [0];
            var result = Methods.Function(temp);
            Assert.True(result is string);
        }
        [Fact]
        public void Methods_Function_ReturnsThrowStringIfCountElementsIs2()
        {
            int[] temp = [125,33];
            var result = Methods.Function(temp);
            Assert.Equal(158, result);
        }
    }
}
