namespace Homework2.Extensions
{
    public static class IEnumerableExt
    {
        public static IEnumerable<TSource> SortByKey<TSource>(this IEnumerable<TSource> list,string? sortKey,string? sortDir)
            where TSource : class
        { 
            var props = typeof(TSource).GetProperties();

            if (sortKey != null && props.Any(p => p.Name == sortKey.ToString()))
            {
                var prop = props.First(p => p.Name == sortKey.ToString());

                if (sortDir == "DESC")
                    return list.OrderByDescending(p => prop.GetValue(p));
                else
                    return list.OrderBy(p => prop.GetValue(p));
            }

            return list;
        }
    }
}
