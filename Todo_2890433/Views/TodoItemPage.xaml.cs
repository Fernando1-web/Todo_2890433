using Todo_2890433.Data;
using Todo_2890433.Models;
namespace Todo_2890433.Views;

[QueryProperty("Item", "Item")]
public partial class TodoItemPage : ContentPage
{
	TodoItem item;
	public TodoItem Item
	{
		get => BindingContext as TodoItem;
		set => BindingContext = value;
	}
	TodoItemDatabase database;
	public TodoItemPage(TodoItemDatabase todoItemDatabase)
	{
		InitializeComponent();
		database = todoItemDatabase;
	}
    async void Button_Clicked(object sender, EventArgs e)
    {
		if (string.IsNullOrWhiteSpace(Item.Nombre))
		{
			await DisplayAlert("Name Required", "Please enter a name for the todo item", "OK");
			return;
		}

		await database.SaveItemAsync(Item);
		await Shell.Current.GoToAsync("..");		
    }
	async void OnDeleteClicked(object sender, EventArgs e)
	{
		if (Item.Id == 0)
			return;
		await database.DeleteItemAsync(Item);
		await Shell.Current.GoToAsync("..");
	}
	async void OnCancelClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("..");
    }
}