namespace LeetCode.Trie;

public class SearchSuggestionsSystem
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var result = new List<IList<string>>();

        var previousProducts = products.Order().ToList();

        for (var i = 0; i < searchWord.Length; i++)
        {
            var tempProducts = previousProducts
                .Where(product => product.Length > i && product[i] == searchWord[i])
                .ToList();

            previousProducts = tempProducts;
            result.Add(tempProducts.Take(3).ToList());
        }
        
        return result;
    }
}