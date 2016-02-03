﻿using System.Collections.Generic;
using Sdl.Community.ExcelTerminology.Model;
using Sdl.Terminology.TerminologyProvider.Core;

namespace Sdl.Community.ExcelTerminology.Services.Interfaces
{
    public interface ITermSearchService
    {
        SearchResult Search(string text, List<ExcelEntry> entries, int maxResultsCount);
    }
}
