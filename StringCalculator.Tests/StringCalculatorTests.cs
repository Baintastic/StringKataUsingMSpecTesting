
using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Tests
{
  
    [Subject("adding no numbers")]
    public class when_adding_zero_numbers
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add(" ");

        It should_return_zero = () => actual.ShouldEqual(0);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding one number")]
    public class when_adding_one_number
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("21");

        It should_return_the_number_itself = () => actual.ShouldEqual(21);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding two numbers")]
    public class when_adding_two_numbers
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("1,4");

        It should_return_the_sum = () => actual.ShouldEqual(5);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding an unknown amount of numbers")]
    public class when_adding_an_unknown_of_numbers
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("1,1,1,2,2,3");

        It should_return_the_sum = () => actual.ShouldEqual(10);

        static StringCalculator stringCalculator;
        static int actual;
    }

    

    [Subject("adding numbers with newlines between them")]
    public class when_adding_numbers_with_newlines_between_them
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("1,4,5\n10");

        It should_return_the_sum = () => actual.ShouldEqual(20);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding numbers with different delimiters between them")]
    public class when_adding_numbers_with_different_delimiters_between_them
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("//;\n1;2");

        It should_return_the_sum = () => actual.ShouldEqual(3);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding negative numbers")]
    public class when_adding_negative_numbers
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
           Exception = Catch.Exception(() => stringCalculator.Add("-1,2,-3"))  ;

        It should_return_the_sum = () => Exception.Message.ShouldEqual("negatives not allowed : -1,-3");

        static StringCalculator stringCalculator;
        static Exception Exception;
    }

    [Subject("adding numbers not bigger than 1000")]
    public class when_adding_numbers_not_bigger_than_1000
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("1001,2");

        It should_return_the_sum = () => actual.ShouldEqual(2);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding numbers with delimiters of any length between them")]
    public class when_adding_numbers_with_delimiters_of_any_length_between_them
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("//[***]\n1***2***3");

        It should_return_the_sum = () => actual.ShouldEqual(6);

        static StringCalculator stringCalculator;
        static int actual;
    }

    [Subject("adding numbers with multiple delimiters of any length between them")]
    public class when_adding_numbers_with_multiple_delimiters_of_any_length_between_them
    {
        Establish context = () =>
                  stringCalculator = new StringCalculator();

        Because of = () =>
            actual = stringCalculator.Add("//[*][%]\n1*2%3");

        It should_return_the_sum = () => actual.ShouldEqual(6);

        static StringCalculator stringCalculator;
        static int actual;
    }
}
