namespace WebApplication1.Service
{
    public class InvalidNamesConstraint : IRouteConstraint
    {
        string[] names = new[] { "Tom", "Sam", "Bereke" }; 
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return !names.Contains(values[routeKey]?.ToString());
        }
    }
}
