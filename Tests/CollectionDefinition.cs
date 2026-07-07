using Xunit;

namespace QA_automation_selenium_xunit.Tests
{
    // Define uma coleção de testes executados de forma sequencial,
    // evitando conflitos causados pela execução paralela.
    [CollectionDefinition(
        "Sequential Tests",
        DisableParallelization = true
    )]
    public class SequentialTestCollection
    {
    }
}