using AI_LAB05.Interfaces;
using System.Text.Json.Serialization;

namespace AI_LAB05.Classes
{
    class Neuron : INeuron
    {
        [JsonInclude]
        public float[] _weights;
        [JsonInclude]
        public int _weights_count;
        public Neuron()
        {
            _weights = new float[0];
            _weights_count = 0;
        }
        public Neuron(int input_count)
        {
            if (input_count > 0)
            {
                _weights_count = input_count + 1;
            }
            else
            {
                throw new ArgumentException("Input count <= 0");
            }
            _weights = new float[_weights_count];
            Random random = new Random();
            _weights[0] = 0.1f;
            for (int i = 1; i < _weights_count; i++)
            {
                _weights[i] = (float)random.Next(-10, 10) / 10; //(float)random.NextDouble();//
            }
        }
        public void CorrectWeight(float delta_w, ISignals signals)
        {
            _weights[0] = _weights[0] + delta_w;
            for (int i = 1; i < _weights_count; i++)
            {
                _weights[i] += delta_w * signals.GetSignal(i - 1);
            }
        }

        public float GetAnswer(ISignals signals)
        {
            float w_sum = _weights[0];
            for (int i = 1; i < _weights_count; i++)
            {
                w_sum += _weights[i] * signals.GetSignal(i - 1);
            }
            return (float)(1f / (1f + Math.Exp(-w_sum)));
        }

        public float GetWeight(int index)
        {
            return _weights[index];
        }
    }
}
