using AI_LAB05.Interfaces;
using System.Text.Json.Serialization;

namespace AI_LAB05.Classes
{
    internal class NeuronLayer : INeuronLayer
    {
        [JsonInclude]
        public List<Neuron> _neuronList;
        [JsonInclude]
        public int _input_count;
        public NeuronLayer()
        {
            _neuronList = new List<Neuron>();
            _input_count = 0;
        }
        public NeuronLayer(int neuron_count, int input_count)
        {
            if (neuron_count >= 0 && input_count >= 0)
            {
                _input_count = input_count;
                _neuronList = new List<Neuron>();
                for (int i = 0; i < neuron_count; i++)
                {
                    _neuronList.Add(new Neuron(_input_count));
                }
            }
            else
            {
                throw new ArgumentException("neuron_count or input_count < 0");

            }
        }
        public int GetNeyronsCount()
        {
            return _neuronList.Count;
        }
        public OutputSignals GetAnswer(ISignals signals)
        {
            OutputSignals result = new OutputSignals();
            foreach (var neuron in _neuronList)
            {
                result.Add(neuron.GetAnswer(signals));
            }
            return result;
        }
        public void CorrectNeurons(float learning_rate, float[] sigma, ISignals signals)
        {
            for (int i = 0; i < _neuronList.Count; i++)
                _neuronList[i].CorrectWeight(learning_rate * sigma[i], signals);
        }
        public float[] GetWeightArr(int index)
        {
            float[] res = new float[_input_count];
            for (int i = 0; i < _input_count; i++)
                res[i] = _neuronList[index].GetWeight(i + 1);
            return res;
        }
        public float GetWeightAt(int neuron_index, int weight_index)
        {
            return _neuronList[neuron_index].GetWeight(weight_index);
        }
    }
}
