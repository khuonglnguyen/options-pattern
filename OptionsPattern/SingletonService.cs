using Microsoft.Extensions.Options;

namespace OptionsPattern
{
    public interface ISingletonService
    {
        UnitOptions GetUnits();
    }

    public class SingletonService : ISingletonService
    {
        private readonly IOptionsMonitor<UnitOptions> _unitOptions;

        public SingletonService(IOptionsMonitor<UnitOptions> unitOptions)
        {
            _unitOptions = unitOptions;
        }
        public UnitOptions GetUnits()
        {
            return _unitOptions.CurrentValue;
        }
    }
}
