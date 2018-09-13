using System.Collections.Generic;
using ExpectedObjects;
using LeetCode_412_BDD;
using LeetCode_412_BDD_Tests.Extension;
using TechTalk.SpecFlow;

namespace LeetCode_412_BDD_Tests.Steps
{
    [Binding]
    public class FizzBuzzLibTestsSteps
    {
        [Given(@"陣列長度輸入 (.*)")]
        public void 假設陣列長度輸入(int length)
        {
            ScenarioContext.Current.Set(length, "length");
        }

        [When(@"呼叫GetResult方法")]
        public void 當呼叫GetResult方法()
        {
            var length = ScenarioContext.Current.Get<int>("length");
            var sut = new Solution();
            var actual = sut.FizzBuzz(length);
            ScenarioContext.Current.Set(actual, "actual");
        }

        [Then(@"結果為")]
        public void 那麼結果為(Table table)
        {
            var expected = table.AsStrings("value");
            var actual = ScenarioContext.Current.Get<IList<string>>("actual");
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}