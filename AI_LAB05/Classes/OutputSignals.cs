using AI_LAB05.Interfaces;

namespace AI_LAB05.Classes
{
    internal class OutputSignals : ISignals
    {
        private List<float> _output_arr;
        
        public OutputSignals()
        {
            _output_arr = new List<float>();

        }
        public void Add(float signal)
        {
            _output_arr.Add(signal);
        }
        public float GetSignal(int index)
        {
            if (index <= _output_arr.Count || index >= 0)
            {
                return _output_arr[index];
            }
            throw new ArgumentException("Index is unbound list");
        }
        public List<float> GetArray()
        {
            return _output_arr;
        }
    }
}
