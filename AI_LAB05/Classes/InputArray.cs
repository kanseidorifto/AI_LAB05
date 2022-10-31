using AI_LAB05.Interfaces;
using System.Text.Json.Serialization;

namespace AI_LAB05.Classes
{
    public class InputArray : IInputSignals
    {
        [JsonInclude]
        public float[] _input_array;
        [JsonInclude]
        public int _category_num;
        [JsonInclude]
        public string _category_name;
        public InputArray()
        {
            _input_array = new float[0];
            _category_num = 0;
            _category_name = "";
        }
        public InputArray(float[] arr, int category_num, string category_name)
        {
            _input_array = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                _input_array[i] = (float)Convert.ToDouble(arr[i]);
            }
            _category_num = category_num;
            _category_name = category_name;
        }
        public float[] GetArray()
        {
            return _input_array;
        }
        public int GetCorrectAnswer()
        {
            return _category_num;
        }

        public float GetSignal(int index)
        {
            return _input_array[index];
        }
    }
}
