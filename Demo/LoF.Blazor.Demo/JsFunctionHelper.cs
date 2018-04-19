namespace LoF.Blazor.Demo
{
    public static class JsFunctionHelper
    {
        public static string GetFunctionName(object obj, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            return $"{obj.GetType().FullName}.{memberName}";
        }

    }
}
