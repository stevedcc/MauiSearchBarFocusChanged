using System.Diagnostics;

namespace PocBrokenEvents;

public class ExtendedSearchBar : SearchBar
{
    public ExtendedSearchBar()
    {
        Unfocused += OnFocusChanged;
        Focused += OnFocusChanged;
        TextChanged += OnTextChanged;
        SearchButtonPressed += OnSearchPressed;
    }

    private void OnFocusChanged(object sender, EventArgs e)
    {
        Debug.WriteLine("ExtendedSearchBar: Focus Changed");
    }

    private void OnSearchPressed(object sender, EventArgs e)
    {
        Debug.WriteLine("ExtendedSearchBar: OnSearchPressed");
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
        Debug.WriteLine("ExtendedSearchBar: OnTextChanged");
    }
}