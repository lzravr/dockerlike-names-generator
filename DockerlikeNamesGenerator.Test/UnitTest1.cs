namespace DockerlikeNamesGenerator.Test;

public class UnitTest1
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