namespace OpenDataWrapper.Enums
{
    public class RepresentationType
    {
        /// <summary>
        /// In the flat representation, all metadata and available data can be accessed and browsed. 
        /// However, no hierarchy appears and data and metadata are shown at the same level.
        /// </summary>
        public const string Flat = "flat";

        /// <summary>
        /// In the tree representation, all metadata and available data can be accessed and browsed as in flat, 
        /// but in this case, any hierarchy of data or metadata is preserved and shown.
        /// </summary>
        public const string Tree = "tree";

        /// <summary>
        /// A node is a measurement station and contains all metadata associated to it.
        /// </summary>
        public const string Node = "node";

        /// <summary>
        /// An Edge is a connection between two stations, improved with additional information, 
        /// including some descriptive field and geometries that describe the connection on a map. 
        /// Internally, an edge is composed of three parts (all calles stations): a start station 
        /// (beginning of the edge), an end station and a station describing the edge. Whenever retrieving an Edge, 
        /// all metadata referring directly to it begin with e, like for example eactive, eavailable, and so on.
        /// </summary>
        public const string Edge = "edge";
    }
}
