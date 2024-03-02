namespace NamesGenerator.Test;

public class UnitTests
{
    [Fact]
    public void CanGenerateName()
    {
        string name = DockerlikeNamesGenerator.GenerateName();

        Assert.NotNull(name);
    }

    [Fact]
    public void IsRightFormat()
    {
        string name = DockerlikeNamesGenerator.GenerateName();
        var pattern = @"[a-z]*_[a-z]*$";

        Assert.Matches(pattern, name);
    }
}