﻿using System;
using System.Collections.Generic;

namespace ElMaAPI.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? SeriesName { get; set; }

    public string? Annotation { get; set; }

    public int Publisher { get; set; }

    public int PlaceOfPublication { get; set; }

    public DateOnly YearOfPublication { get; set; }

    public int? BbkCode { get; set; }

    public string? Image { get; set; }

    public virtual Bbk? BbkCodeNavigation { get; set; }

    public virtual Publicationplase PlaceOfPublicationNavigation { get; set; } = null!;

    public virtual Publisher PublisherNavigation { get; set; } = null!;
}
