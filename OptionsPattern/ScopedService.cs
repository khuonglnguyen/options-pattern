using Microsoft.Extensions.Options;

namespace OptionsPattern
{
    public interface IScopedService
    {
        UnitOptions GetUnits();
    }

    public class ScopedService : IScopedService
    {
        private readonly UnitOptions _unitOptions;

        public ScopedService(IOptionsSnapshot<UnitOptions> unitOptions)
        {
            _unitOptions = unitOptions.Value;
        }

        public UnitOptions GetUnits()
        {
            return _unitOptions;
        }
    }
}
