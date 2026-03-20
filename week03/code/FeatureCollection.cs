public class FeatureCollection
{
    public string Type { get; set; }
    public Feature[] Features { get; set; }

    public class Feature
    {
        public string Type { get; set; }
        public FeatProps Properties { get; set; }

        public class FeatProps
        {
            public double? Mag { get; set; }
            public string Place { get; set; }
        }
    }
}


