using System.Text.Json.Serialization;

namespace AI_LAB05.Classes
{
    public class Settings
    {
        [JsonInclude]
        public int _dataX;
        [JsonInclude]
        public int _dataY;
        [JsonInclude]
        public int[] _layers_characteristic;
        [JsonInclude]
        public int _outputclasses_count;
        [JsonInclude]
        public int _max_iter;
        [JsonInclude]
        public float _precision;
        [JsonInclude]
        public float _pen_width;
        public Settings()
        {
            _dataX = 10;
            _dataY = 10;
            _layers_characteristic = new int[] { 50 };
            _outputclasses_count = 10;
            _max_iter = 1000;
            _precision = 0.001f;
            _pen_width = 30f;
        }
        public Settings(int dataX, int dataY, int[] layers_characteristic, int outputclasses_count, int max_iter, float precision, float pen_width)
        {
            _dataX = dataX;
            _dataY = dataY;
            _layers_characteristic = layers_characteristic;
            _outputclasses_count = outputclasses_count;
            _max_iter = max_iter;
            _precision = precision;
            _pen_width = pen_width;
        }
    }
}
