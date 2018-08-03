﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization
{
    internal static class TypedShimNavigatorExtensions
    {
        public static IElementNavigator ToElementNavigator(this ISourceNavigator sourceNav, string type = null, IStructureDefinitionSummaryProvider provider = null)
        {
            IElementNavigator typedNav;
            bool hasError = false;

            using (sourceNav.Catch((o, a) => hasError = a.Exception is FormatException))
            {
                var dummy = sourceNav.Text;
            }

            if (provider != null && !hasError)
            {
                // If no type is given, assume we are on a resource and try to get the
                // resoure name from the underlying source. If that fails, take the name of
                // the node as a last resort;
                var sourceType = type ?? sourceNav.GetResourceType() ??
                    throw Error.Argument(nameof(sourceNav), "Underlying navigator is not located on a resource, please supply a type argument");
                typedNav = new TypedNavigator(sourceNav, sourceType, provider);
            }
            else
                typedNav = new TypedShimNavigator(sourceNav);

            return typedNav;
        }
    }

    internal class TypedShimNavigator : IElementNavigator, IAnnotated, IExceptionSource
    {
        private ISourceNavigator _sourceNav;

        public TypedShimNavigator(ISourceNavigator sourceNav)
        {
            this._sourceNav = sourceNav;

            if (sourceNav is IExceptionSource ies && ies.ExceptionHandler == null)
                ies.ExceptionHandler = (o, a) => ExceptionHandler.NotifyOrThrow(o, a);
        }

        public ExceptionNotificationHandler ExceptionHandler { get; set; }

        public string Name => _sourceNav.Name;

        public string Type => null;

        public object Value => _sourceNav.Text;

        public string Location => _sourceNav.Path;

        public IElementNavigator Clone() =>
            new TypedShimNavigator(_sourceNav.Clone())
            {
                ExceptionHandler = this.ExceptionHandler
            };

        public bool MoveToFirstChild(string nameFilter = null) => _sourceNav.MoveToFirstChild(nameFilter);

        public bool MoveToNext(string nameFilter = null) => _sourceNav.MoveToNext(nameFilter);

        IEnumerable<object> IAnnotated.Annotations(Type type)
        {
            if (type == typeof(TypedShimNavigator))
                return new[] { this };
            else
                return _sourceNav.Annotations(type);
        }
    }
}