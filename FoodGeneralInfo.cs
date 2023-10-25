public class FoodGeneralInfo
{
    public string Url { get; set; } = string.Empty;
    public string ItalianName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string FoodCode { get; set; } = string.Empty;
    public string ScientificName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public string Information { get; set; } = string.Empty;
    public string NumberOfSamples { get; set; } = string.Empty;
    public string EatablePartpercentage { get; set; } = string.Empty;
    public string Portion { get; set; } = string.Empty;
    public List<Nutrition> Nutritions { get; set; } = new List<Nutrition>();
    public List<Langual> LangualCodes { get; set; } = new List<Langual>();
    public Chart ChartData { get; set; } = new Chart();

}
