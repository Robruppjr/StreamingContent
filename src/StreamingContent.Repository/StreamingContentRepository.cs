

//* Repository Pattern
public class StreamingContentRepository
{
    //* Used when we interact w/ data
    //* dont have a database right no, we are going to simulate one using List<T> (collection)
    //* will be at the top of ou]r class 
    //! THIS IS OUR FAKE DATABASE
    //? protected -> only inheriting members
    protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

    //* We will be using C.R.U.D.

    //? Create
    public bool AddContentToDirectory(StreamingContent content)
    {
        //* Check the overall _contentDirectory count
        int startingCount = _contentDirectory.Count();

        //* Adding content to the Fake Database....
        _contentDirectory.Add(content);

        //* After adding the startingCount, we can Add teh content and then compare the current count
        //* this will evaluate to true/false
        bool wasAdded = (_contentDirectory.Count > startingCount)? true : false;
        return wasAdded;
    }
    //? REad
    public List<StreamingContent> GetAllContent()
    {
        return _contentDirectory;
    }

    //? Read #2
    //! string title is the Unique Identifier that describes a specific move
    //* considered to be a helper method
    public StreamingContent GetContentByTitle(string title)
    {
        //* look in all of the _contentDirectory and check if the title exists
        foreach (StreamingContent content in _contentDirectory)
        {
            if(content.Title == title)
            {
            return content;
            }
        }
        return null;
    }

    //? Update
    //? Update clear everthing!
    public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
    {
        //* use helper method (GetContentByTitle)
        StreamingContent oldContent = GetContentByTitle(originalTitle);

        //* check if oldContent actually has content 
        if(oldContent != null)
        {
            oldContent.Title = newContent.Title;
            oldContent.Description = newContent.Description;
            oldContent.MaturityRating = newContent.MaturityRating;
            oldContent.StarRating = newContent.StarRating;
            oldContent.TypeOfGenre = newContent.TypeOfGenre;

            return true;
        }
        return false;
    }

    //? Delete
    public bool DeleteExisitingContent(StreamingContent content)
    {
        bool deleteResult = _contentDirectory.Remove(content);
        return deleteResult;
    }

    //? You can make other methods
    //? Yoou are not restriceted to crud
    //* Get streaming content by Genre
    public List<StreamingContent> GetStreamingContentbyGenre(GenreType type)
    {
        //todo: list starting point (empty list)
        var genreList = new List<StreamingContent>();
        
        //todo: loops through entire directory
        foreach (var content in _contentDirectory)
        {
            //todo: if we find a genre that matches...
            if(content.TypeOfGenre == type)
            {
                //Todo: add it to the above list
                genreList.Add(content);
            }
        }
        //todo: return or 'give us back' the value
        return genreList;
    }
}

//todo: Challenges:
        //todo: Get by other parameters
        //todo: Get By Rating
        //todo: Get By Family Rating
        //todo: Etc.
