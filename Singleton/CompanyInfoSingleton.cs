namespace DesignPatterns.Singleton;

public sealed class CompanyInfoSingleton
{
    private CompanyInfoSingleton() {}

    public static CompanyInfoSingleton Instance  {get; } = new();

    public Guid FixedCompanyId { get; } = Guid.NewGuid();
}