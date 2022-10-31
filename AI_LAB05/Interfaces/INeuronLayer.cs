using AI_LAB05.Classes;

namespace AI_LAB05.Interfaces
{
    internal interface INeuronLayer
    {
        public int GetNeyronsCount();
        public OutputSignals GetAnswer(ISignals signals);
        public void CorrectNeurons(float learning_rate, float[] sigma, ISignals signals);
        public float[] GetWeightArr(int index);
        public float GetWeightAt(int neuron_index, int weight_index);
    }
}
