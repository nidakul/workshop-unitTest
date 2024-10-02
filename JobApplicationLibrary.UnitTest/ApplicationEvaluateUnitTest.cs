using JobApplicationLibrary.Models;

namespace JobApplicationLibrary.UnitTest;

public class ApplicationEvaluateUnitTest
{

    //[Test]
    //public void Test1()
    //{
    //    //Assert.Pass();
    //    Assert.Fail("This test failed");
    //}

    //method name rules
    //UnitOfWork_Condition_ExpectedResult
    //UnitOfWork_Result_Condition
    //Condition_Result
    [Test]
    public void Application_WithUnderAge_TransferredToAutoRejected()
    {
        //Arrange
        var evaluator = new ApplicationEvaluator();
        //Testimiz sadece yaşı test ettiği için sadece yaşı gönderiyoruz formda
        var form = new JobApplication()
        {
            Applicant = new Applicant()
            {
                Age = 17
            }
        };

        //Action
        var appResult = evaluator.Evaluate(form);

        //Assert
        Assert.AreEqual(ApplicationResult.AutoRejected , appResult);
    }
}


