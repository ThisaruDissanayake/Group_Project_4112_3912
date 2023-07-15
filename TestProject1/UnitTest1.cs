using Group.Model;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var patient = new Patient();

            // Act
            patient.Pid = 1;
            patient.FirstName = "John";
            patient.LastName = "Doe";
            patient.Age = 30;
            patient.Ward = "A1";

            // Assert
            Assert.Equal(1, patient.Pid);
            Assert.Equal("John", patient.FirstName);
            Assert.Equal("Doe", patient.LastName);
            Assert.Equal(30, patient.Age);
            Assert.Equal("A1", patient.Ward);
            Assert.Null(patient.MedicalPriorities);


        }
    }
}