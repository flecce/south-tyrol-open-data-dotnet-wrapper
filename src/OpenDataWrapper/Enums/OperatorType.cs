namespace OpenDataWrapper.Enums
{
    public static class OperatorType
    {
        /// <summary>
        /// Equal.
        /// </summary>
        public static string Eq = "eq";

        /// <summary>
        /// Not Equal.
        /// </summary>
        public static string Neq = "neq";

        /// <summary>
        /// Less Than.
        /// </summary>
        public static string Lt = "lt";

        /// <summary>
        /// Greater Than.
        /// </summary>
        public static string Gt = "gt";

        /// <summary>
        /// Less Than Or Equal.
        /// </summary>
        public static string Lteq = "lteq";

        /// <summary>
        /// Greater Than Or Equal.
        /// </summary>
        public static string Gteq = "qteq";

        /// <summary>
        /// Regular Expression.
        /// </summary>
        public static string Re = "re";

        /// <summary>
        /// Insensitive Regular Expression.
        /// </summary>
        public static string Ire = "ire";

        /// <summary>
        /// Negated Regular Expression.
        /// </summary>
        public static string Nre = "nre";

        /// <summary>
        /// Negated Insensitive Regular Expression.
        /// </summary>
        public static string Nire = "nire";

        /// <summary>
        /// Bounding box intersecting objects(ex., a street that is only partially covered by the box).
        /// </summary>
        public static string Bbi = "bbi";

        /// <summary>
        /// Bounding box containing objects(ex., a station or street,
        /// that is completely covered by the box).
        /// </summary>
        public static string Bbc = "bbc";

        /// <summary>
        /// True, if the value of the alias can be found within the given list.
        /// Example = name.in.(Peter, Patrick, Rudi).
        /// </summary>
        public static string In = "in";

        /// <summary>
        /// False, if the value of the alias can be found within the given list.
        /// Example = name.nin.(Peter, Patrick, Rudi).
        /// </summary>
        public static string nNn = "nin";
    }
}
