    using System.Collections.Generic;

    interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> objects, ISpecification<T> specification);
    }
