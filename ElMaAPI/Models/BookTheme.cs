﻿using System;
using System.Collections.Generic;

namespace ElMaAPI.Models;

public partial class BookTheme
{
    public int? BookId { get; set; }

    public int? ThemesId { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Theme? Themes { get; set; }
}
