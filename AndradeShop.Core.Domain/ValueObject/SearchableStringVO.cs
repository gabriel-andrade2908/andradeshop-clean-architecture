using AndradeShop.Core.Domain.Helperrs.Extensions;

namespace AndradeShop.Core.Domain.ValueObject
{
    public class SearchableStringVO
    {
        public SearchableStringVO(string value)
        {
            Value = value;
            SearchableValue = value.ToSerachable();
        }


        public string Value { get; private set; }
        public string SearchableValue { get; private set; }
    }
}
