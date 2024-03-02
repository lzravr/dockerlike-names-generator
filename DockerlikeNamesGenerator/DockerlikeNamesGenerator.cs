namespace NamesGenerator;
public static class DockerlikeNamesGenerator
{
    public static string GenerateName()
    {
        Random rnd = new Random();

        return Words.Left[rnd.Next(Words.Left.Length)] + "_" + Words.Right[rnd.Next(Words.Right.Length)];
    }
}
