using System;
using ProtoPlantApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace ProtoPlantApp.ViewModels;
 
public partial class MyPlantsViewModel : ObservableObject
{
	[ObservableProperty]
	List<Plants> plants;

	public MyPlantsViewModel()
	{
		LoadPlants();
	}
    private void LoadPlants()
    {

		Plants = new()
		{
			new Plants(
				name:"Monstera",
				description: "Plant that tends to have venistrations, and is a stable in any plant person houselhold",
				FirstDateTime:DateTime.UtcNow.AddDays(1),
				LastDateTime:DateTime.UtcNow.AddDays(1),
				NextDateTime:DateTime.UtcNow.AddDays(7),
				Image: new Uri("https://cdn.shopify.com/s/files/1/0150/6262/products/the-sill_monstera_variant_medium_hyde_mint_f0e6d601-426c-40fe-abc6-b0a1f4dce17b.jpg?v=1672212220"),
				Family: new List<string> {"Arum, Philodendrin, Araceae"},
				Environment: new List<string> {"Tropical"}),
			new Plants(
                name:"Alocasia Polly",
                description: "Very unique plant that is for more advanced plant parents, Has beautiful leaves, and is very stingy to specific care",
                FirstDateTime:DateTime.UtcNow.AddDays(1),
                LastDateTime:DateTime.UtcNow.AddDays(1),
                NextDateTime:DateTime.UtcNow.AddDays(7),
                Image: new Uri("https://i.etsystatic.com/21427386/r/il/7f66be/2913655055/il_570xN.2913655055_iz7t.jpg"),
                Family: new List<string> {"Aroid, Alocasia"},
                Environment: new List<string> {"Tropical"})
		};

    }
}


