using System.Collections.Generic;
using InertiaAdapter.Extensions;
using InertiaAdapter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace InertiaAdapter.Core
{
    public class ViewData
    {
        private readonly IDictionary<string, object>? _viewData;

        public ViewDataDictionary ViewDataDictionary { get; }


        public ViewData(Page? page, ActionContext? ac, IDictionary<string, object>? viewData)
        {
            _viewData = viewData;

            ViewDataDictionary =
                new ViewDataDictionary(new EmptyModelMetadataProvider(), ac.NotNull().ModelState) { Model = page };

            PrepareViewDataDictionary();
        }

        private void PrepareViewDataDictionary()
        {
            if (_viewData is null) return;

            foreach (var (key, value) in _viewData)
                ViewDataDictionary[key] = value;
        }
    }
}
